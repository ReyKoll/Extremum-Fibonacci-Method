namespace FMath

module Fibonacci =
    let rec Get n =
        if n < 2 then 
            1
        else 
            Get (n - 1) + Get (n - 2)

module Function =
    let Sin x = sin(x)
    let Cos x = cos(x)
    let Parabola x = x * x - 4.0
    let Line x = x - 2.0