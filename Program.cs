
using EFRelationships2;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("One to Many Relationship using Entity Framework!");

MyDbContext Context = new MyDbContext();

Bus MyBus = Context.Buses.Include(x => x.PassengersList).FirstOrDefault(x => x.Id == 1);

//Select Passengers travelling with Bus id =1

Console.WriteLine("List of Passengers travelling by Bus No 1");

foreach(var item in MyBus.PassengersList)
{
    Console.WriteLine(item.Name);
}
