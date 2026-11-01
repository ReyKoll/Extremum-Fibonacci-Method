namespace FMath

/// Числа Фибоначчи и элементарные функции для метода оптимизации.
module Fibonacci =

    /// <summary>
    /// n-е число Фибоначчи: Get(0) = 1, Get(1) = 1, Get(2) = 2, Get(3) = 3, Get(4) = 5, ...
    /// </summary>
    /// <remarks>
    /// Итеративное вычисление за O(n) — вместо исходной наивной рекурсии O(φ^n),
    /// которая экспоненциально взрывалась при n &gt; 30.
    /// </remarks>
    let Get (n: int) : float =
        match n with
        | n when n <= 1 -> 1.0
        | n when n > 400 -> 1.7976931348623157e308 // защита от переполнения double: F(407) уже не помещается
        | _ ->
            let mutable a = 1.0   // F(n-1)
            let mutable b = 1.0   // F(n)
            for _ in 2 .. n do
                let next = a + b
                a <- b
                b <- next
            b

    /// Минимальный индекс n, при котором Get(n) >= value.
    let IndexFor (value: float) : int =
        let mutable n = 1
        while Get n < value && n < 400 do
            n <- n + 1
        n

/// Элементарные функции, доступные в приложении.
module Function =
    let Sin (x: float) = sin x
    let Cos (x: float) = cos x
    let Parabola (x: float) = x * x - 4.0
    let Line (x: float) = x - 2.0
