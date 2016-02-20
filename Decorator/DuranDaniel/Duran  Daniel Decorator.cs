1. /// <summary>
2. /// The 'Component' interface
3. /// </summary>
4. public interface Vehicle
5. {
6.  string Make { get; }
7.  string Model { get; }
8.  double Price { get; }
9. }
10.  
11. /// <summary>
12. /// The 'ConcreteComponent' class
13. /// </summary>
14. public class HondaCity : Vehicle
15. {
16.  public string Make
17.  {
18.  get { return "HondaCity"; }
19.  }
20.  
21.  public string Model
22.  {
23.  get { return "CNG"; }
24.  }
25.  
26.  public double Price
27.  {
28.  get { return 1000000; }
29.  }
30. }
31.  
32. /// <summary>
33. /// The 'Decorator' abstract class
34. /// </summary>
35. public abstract class VehicleDecorator : Vehicle
36. {
37.  private Vehicle _vehicle;
38.  
39.  public VehicleDecorator(Vehicle vehicle)
40.  {
41.  _vehicle = vehicle;
42.  }
43.  
44.  public string Make
45.  {
46.  get { return _vehicle.Make; }
47.  }
48.  
49.  public string Model
50.  {
51.  get { return _vehicle.Model; }
52.  }
53.  
54.  public double Price
55.  {
56.  get { return _vehicle.Price; }
57.  }
58.  
59. }
60.  
61. /// <summary>
62. /// The 'ConcreteDecorator' class
63. /// </summary>
64. public class SpecialOffer : VehicleDecorator
65. {
66.  public SpecialOffer(Vehicle vehicle) : base(vehicle) { }
67.  
68.  public int DiscountPercentage { get; set; }
69.  public string Offer { get; set; }
70.  
71.  public double Price
72.  {
73.  get
74.  {
75.  double price = base.Price;
76.  int percentage = 100 - DiscountPercentage;
77.  return Math.Round((price * percentage) / 100, 2);
78.  }
79.  }
80.  
81. }
82.  
83. /// <summary>
84. /// Decorator Pattern Demo
85. /// </summary>
86. class Program
87. {
88.  static void Main(string[] args)
89.  {
90.  // Basic vehicle
91.  HondaCity car = new HondaCity();
92.  
93.  Console.WriteLine("Honda City base price are : {0}", car.Price);
94.  
95.  // Special offer
96.  SpecialOffer offer = new SpecialOffer(car);
97.  offer.DiscountPercentage = 25;
98.  offer.Offer = "25 % discount";
99.  
100.  Console.WriteLine("{1} @ Diwali Special Offer and price are : {0} ", offer.Price, offer.Offer);
101.  
102.  Console.ReadKey();
103.  
104.  }
105. }


