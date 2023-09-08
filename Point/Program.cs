using Points;

Point p1 = new Point();
Point p2 = new Point();
Point p3 = new Point();
Console.WriteLine($"p1[{p1}], p2[{p2}], p3[{p3}]");
Console.WriteLine(HighestPoint(p1, p2, p3));
Console.WriteLine(EqualPoints(p1, p2, p3) ? "There Are 2 Equal Points" : "There Are No Equal Points");
Point p4 = new Point(p1);
p4.Move(1.5, 2.5);
Console.WriteLine(p4);

bool EqualPoints(Point p1, Point p2, Point p3)
{
    return p1.Equals(p2) || p2.Equals(p3) || p1.Equals(p3);
}

Point HighestPoint(Point p1, Point p2, Point p3)
{
    return p1.IsAbove(p2) ? p1.IsAbove(p3) ? p1 : p3 : p2.IsAbove(p3) ? p2 : p3;
}

bool SameXposOrYpos(Point p1, Point p2, Point p3)
{
    return p1.x == p2.x && p3.x == p1.x && p2.x == p3.x ||
        p1.y == p2.y && p3.y == p1.y && p2.y == p3.y;
}