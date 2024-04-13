namespace GeometryCalculator

module Ellipsoid =
    open System

    module private Area =
        module Rotational =
            let e a c =
                sqrt(1. - a**2. / c**2.)
        module General = 
            open FSharp.Stats.Integration

            let f psi k =
                let integral x = 1. / sqrt(1. - k**2. * sin(x)**2.)
                integral |> NumericalIntegration.definiteIntegral(LeftEndpoint, 0., psi, 100)
            let e psi k = 
                let integral x = sqrt(1. - k**2. * sin(x)**2.)
                integral |> NumericalIntegration.definiteIntegral(LeftEndpoint, 0., psi, 100)

            let m a b c =
                a**2. * (b**2. - c**2.) / (b**2. * (a**2. - c**2.))

            let private epsilon a c =
                sqrt(1. - (c**2. / a**2.))
            let tau a c =
                asin(epsilon a c)

        let sphere r = 4. * Math.PI * r**2.

        let rotationalEllipsoid c a = 
            if c < a then
                let eValue = Rotational.e c a
                2. * Math.PI * a**2. + Math.PI * c**2. / eValue * log((1. + eValue) / (1. - eValue))
            else
                let eValue = Rotational.e a c
                2. * Math.PI * a**2. * (1. + c / (a * eValue) * asin(eValue))

        let generalEllipsoid a b c = 
            let tauValue = General.tau a c
            let mValue = General.m a b c
            2. * Math.PI * (c**2. + (b * c**2.) / sqrt(a**2. - c**2.) * (General.f tauValue mValue) + b * sqrt(a**2. - c**2.) * (General.e tauValue mValue))


    let volume a b c =
        if a > 0. && b > 0. && c > 0. then
            4. / 3. * Math.PI * a * b * c
        else
            nan

    let area a b c =
        if a > 0. && b > 0. && c > 0. then
            if a = b && b = c then
                Area.sphere a
            elif a = b || b = c then
                if a = b then
                    Area.rotationalEllipsoid c a
                else
                    Area.rotationalEllipsoid a b
            else
                if a > b && b > c then
                    Area.generalEllipsoid a b c
                else
                    nan
        else
            nan