(*
a. Define the data type declaration (PclShape) for Rectangleand RightTriangle
*)
type PclShape = 
    | Rectangle of float * float
    | RightTriangle of float * float


(* 
b. Create some values to represent both shapes
*)
let rectangle = Rectangle(2.5, 4.0)
let rightTriangle = RightTriangle(12.7, 8.34)

(*
c. Define a function pclArea : PclShape -> float that calculates the area of a shape
*)
let pclArea =
    function
    | Rectangle (a, b) -> a * b
    | RightTriangle (a, b) -> (a * b) / 2.0

printfn "Rectangle area = %f" (pclArea rectangle)
printfn "RightTriangle area = %f" (pclArea rightTriangle)
    
(*
d. Define a function pclPerimeterto calculate the perimeter of a rectangle 
*)
let pclPerimeter = 
    function
    | Rectangle (a, b) -> (a*a) + (b*b) 
    | _ -> 0.0

printfn "Rectangle Perimeter = %f" (pclPerimeter rectangle)

(*
e. Redefine the PclShapeto use records instead of tuples (PclShapeR)
*)
type shape = { a : float; b : float }
type PclShapeR = 
    | RectangleR of shape
    | RightTriangleR of shape

let rectangleR = RectangleR( { a = 2.5; b = 4.0 } )
let rightTriangleR = RightTriangleR( { a = 12.7; b = 8.34 } )

let pclAreaR =
    function
    | RectangleR shape -> shape.a * shape.b
    | RightTriangleR shape -> (shape.a * shape.b) / 2.0

printfn "Rectangle area = %f" (pclAreaR rectangleR)
printfn "RightTriangle area = %f" (pclAreaR rightTriangleR)
