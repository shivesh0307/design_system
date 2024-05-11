// See https://aka.ms/new-console-template for more information
// Used to prevent class explosion 
// In this example we have some pizza and lot of permutation & combinations are possible
// IT both is-a amd has-a
using DecoratorDesignPattern.Pizza;
using DecoratorDesignPattern.Toppings;

Console.WriteLine("Hello, World!");

// FarmHouse Pizza With Extra Cheese , Mushroom and Extra Cheese 

BasePizza pizza =new ExtraCheese(new Mushroom (new ExtraCheese(new Farmhouse())));

Console.WriteLine(pizza.Cost());


// Veggie Delight Pizza With  Mushroom , Extra Cheese and  Mushroom  

BasePizza pizza2 =new Mushroom(new ExtraCheese(new Mushroom(new VegDelight())));

Console.WriteLine(pizza2.Cost());
