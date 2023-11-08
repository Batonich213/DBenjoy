using ConsoleApp;
using (ApplicationContext db = new ApplicationContext())
{

    Human tom = new Human { Name = "Tom", Age = 33 };
    Human Piter = new Human { Name = "Piter", Age = 22 };

    db.Human.Add(tom);
    db.Human.Add(Piter);
    db.SaveChanges();
    Console.WriteLine("Объекты успешно сохранены");


    var Humans = db.Human.ToList();
    Console.WriteLine("Object list: \n");
    foreach (Human u in Humans)
    {
        Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
    }
}
