printfn "Welcome in GeometryCalculator example!"

// Ellipsoid
printfn "\nEllipsoid:"

// Volume
let volume1 = GeometryCalculator.Ellipsoid.volume 3.0 2.0 1.5
printfn $"Volume for a={3}, b={2}, c={1.5}: {volume1}"

let volume2 = GeometryCalculator.Ellipsoid.volume 3.0 1.5 1.5
printfn $"Volume for a={3}, b={1.5}, c={1.5}: {volume2}"

let volume3 = GeometryCalculator.Ellipsoid.volume 2.0 2.0 2.0
printfn $"Volume for a={2}, b={2}, c={2}: {volume3}"

// Area
let area1 = GeometryCalculator.Ellipsoid.area 3.0 2.0 1.5
printfn $"Area for a={3}, b={2}, c={1.5}: {area1}"

let area2 = GeometryCalculator.Ellipsoid.area 3.0 1.5 1.5
printfn $"Area for a={3}, b={1.5}, c={1.5}: {area2}"
let area3 = GeometryCalculator.Ellipsoid.area 2.0 2.0 2.0
printfn $"Area for a={2}, b={2}, c={2}: {area3}"