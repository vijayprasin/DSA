Write a function areaAndPerimeter(shape, dims) that returns the area and the perimeter of a 2D shape as a two-element array [area, perimeter], with each value rounded to two decimal places.

The shape argument is a string naming one of four supported shapes, and dims is an array of the numbers that describe it:

"rectangle" with dims = [length, width]. Area is length * width, and perimeter is 2 * (length + width).
"square" with dims = [side]. Area is side * side, and perimeter is 4 * side.
"circle" with dims = [radius]. Area is PI * radius * radius, and the perimeter is the circumference 2 * PI * radius. Use PI = 3.14159.
"triangle" with dims = [a, b, c]. Perimeter is a + b + c, and area comes from Heron's formula: let s = (a + b + c) / 2, then area is sqrt(s * (s - a) * (s - b) * (s - c))

  Example 1:
Input: shape = "rectangle", dims = [4,3]

Output: [12,14]

Example 2:
Input: shape = "triangle", dims = [3,4,5]

Output: [6,12]

Constraints:
shape is one of "rectangle", "square", "circle", "triangle".
Every number in dims is positive.
For a triangle, the three sides form a valid triangle.
Use PI = 3.14159 and round each returned value to two decimal places.


public class Solution {
    public double[] AreaAndPerimeter(string shape, double[] dims) {

        double area=0;
        double perimeter=0;
        double PI=3.14159;

        if(shape=="rectangle"){
            double lenght=dims[0];
            double width=dims[1];

            area=lenght*width;
            perimeter=2*(lenght+width);
        }
        else if(shape=="square"){
            double side=dims[0];

            area=side*side;
            perimeter=4*side;
        }
        else if(shape=="circle"){
            double radius=dims[0];
            area=PI*radius*radius;
            perimeter=2*PI*radius;
        }
        else if(shape=="triangle"){
            double a=dims[0];
            double b=dims[1];
            double c=dims[2];

            perimeter=a+b+c;
            double s=perimeter/2;
            area=Math.Sqrt(s*(s-a)*(s-b)*(s-c));
        }
        return new double[]{
            Math.Round(area,2),
            Math.Round(perimeter,2)
        };

    }
}
