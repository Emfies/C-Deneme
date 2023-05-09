namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Managers m = new Managers("Mehmet Fatih", "Sümer", 1, 1000, 25);
            Managers m1 = new Managers("Mahmut", "Sümer", 2, 900, 52);
            Managers m2 = new Managers("Kezban", "Sümer", 3, 800, 46);
            Chiefs c = new Chiefs("Rabia", "Sümer", 4, 700, 19);
            Chiefs c1 = new Chiefs("Onur", "Arık", 5, 1000, 25);
            Chiefs c2 = new Chiefs("Akif", "Sümer", 6, 700, 26);
            SoftwareDevelopers sd = new SoftwareDevelopers("Evrim", "Sümer", 7, 800, 24);
            SoftwareDevelopers sd1 = new SoftwareDevelopers("Mehmet", "Elcuman", 8, 500, 25);
            SoftwareDevelopers sd2 = new SoftwareDevelopers("Samed", "Gülmez", 9, 600, 25);
            Workers w = new Workers("Halim Han", "Hidayetoğlu", 10, 700, 25);
            Workers w1 = new Workers("Oğuzhan", "Oluk", 11, 800, 27);
            Workers w2 = new Workers("Onur", "Hasret", 12, 900, 25);
            Console.WriteLine("Personel Veritabanımıza Hoşgeldiniz.");
            Console.WriteLine("Yapmak İstediğiniz İşlemi Seçiniz.");
            Console.WriteLine("1-Tüm Personelleri Görmek");
            Console.WriteLine("2-Müdürleri Görmek");
            Console.WriteLine("3-Şefleri Görmek");
            Console.WriteLine("4-Yazılım Geliştiricileri Görmek");
            Console.WriteLine("5-İşçileri Görmek");
            Console.WriteLine("6-Yaşlarına Göre Personerlleri Görmek");
            Console.WriteLine("7-Çıkış");
                string secim = Console.ReadLine();
            switch (secim)
            {
                case "1":
                    Console.WriteLine("Tüm Personelleri Görüntülemektesiniz");
                    Console.WriteLine(m.Name);
                    Console.WriteLine(m.Surname);
                    Console.WriteLine(m.Age);
                    Console.WriteLine(m.EmployeeID);
                    Console.WriteLine(m.Salary);
                    Console.WriteLine("**************************************");
                    Console.WriteLine(m1.Name);
                    Console.WriteLine(m1.Surname);
                    Console.WriteLine(m1.Age);
                    Console.WriteLine(m1.EmployeeID);
                    Console.WriteLine(m1.Salary);
                    Console.WriteLine("**************************************");
                    Console.WriteLine(m2.Name);
                    Console.WriteLine(m2.Surname);
                    Console.WriteLine(m2.Age);
                    Console.WriteLine(m2.EmployeeID);
                    Console.WriteLine(m2.Salary);
                    Console.WriteLine("**************************************");
                    Console.WriteLine(c.Name);
                    Console.WriteLine(c.Surname);
                    Console.WriteLine(c.Age);
                    Console.WriteLine(c.EmployeeID);
                    Console.WriteLine(c.Salary);
                    Console.WriteLine("**************************************");
                    Console.WriteLine(c1.Name);
                    Console.WriteLine(c1.Surname);
                    Console.WriteLine(c1.Age);
                    Console.WriteLine(c1.EmployeeID);
                    Console.WriteLine(c1.Salary);
                    Console.WriteLine("**************************************");
                    Console.WriteLine(c2.Name);
                    Console.WriteLine(c2.Surname);
                    Console.WriteLine(c2.Age);
                    Console.WriteLine(c2.EmployeeID);
                    Console.WriteLine(c2.Salary);
                    Console.WriteLine("**************************************");
                    Console.WriteLine(sd.Name);
                    Console.WriteLine(sd.Surname);
                    Console.WriteLine(sd.Age);
                    Console.WriteLine(sd.EmployeeID);
                    Console.WriteLine(sd.Salary);
                    Console.WriteLine("**************************************");
                    Console.WriteLine(sd1.Name);
                    Console.WriteLine(sd1.Surname);
                    Console.WriteLine(sd1.Age);
                    Console.WriteLine(sd1.EmployeeID);
                    Console.WriteLine(sd1.Salary);
                    Console.WriteLine("**************************************");
                    Console.WriteLine(sd2.Name);
                    Console.WriteLine(sd2.Surname);
                    Console.WriteLine(sd2.Age);
                    Console.WriteLine(sd2.EmployeeID);
                    Console.WriteLine(sd2.Salary);
                    Console.WriteLine("**************************************");
                    Console.WriteLine(w.Name);
                    Console.WriteLine(w.Surname);
                    Console.WriteLine(w.Age);
                    Console.WriteLine(w.EmployeeID);
                    Console.WriteLine(w.Salary);
                    Console.WriteLine("**************************************");
                    Console.WriteLine(w1.Name);
                    Console.WriteLine(w1.Surname);
                    Console.WriteLine(w1.Age);
                    Console.WriteLine(w1.EmployeeID);
                    Console.WriteLine(w1.Salary);
                    Console.WriteLine("**************************************");
                    Console.WriteLine(w2.Name);
                    Console.WriteLine(w2.Surname);
                    Console.WriteLine(w2.Age);
                    Console.WriteLine(w2.EmployeeID);
                    Console.WriteLine(w2.Salary);
                    Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("Müdürleri Görüntülemektesiniz.");
                    Console.WriteLine(m.Name);
                    Console.WriteLine(m.Surname);
                    Console.WriteLine(m.Age);
                    Console.WriteLine(m.EmployeeID);
                    Console.WriteLine(m.Salary);
                    Console.WriteLine("**************************************");
                    Console.WriteLine(m1.Name);
                    Console.WriteLine(m1.Surname);
                    Console.WriteLine(m1.Age);
                    Console.WriteLine(m1.EmployeeID);
                    Console.WriteLine(m1.Salary);
                    Console.WriteLine("**************************************");
                    Console.WriteLine(m2.Name);
                    Console.WriteLine(m2.Surname);
                    Console.WriteLine(m2.Age);
                    Console.WriteLine(m2.EmployeeID);
                    Console.WriteLine(m2.Salary);
                    Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine("Şefleri Görüntülemektesiniz.");
                    Console.WriteLine(c.Name);
                    Console.WriteLine(c.Surname);
                    Console.WriteLine(c.Age);
                    Console.WriteLine(c.EmployeeID);
                    Console.WriteLine(c.Salary);
                    Console.WriteLine("**************************************");
                    Console.WriteLine(c1.Name);
                    Console.WriteLine(c1.Surname);
                    Console.WriteLine(c1.Age);
                    Console.WriteLine(c1.EmployeeID);
                    Console.WriteLine(c1.Salary);
                    Console.WriteLine("**************************************");
                    Console.WriteLine(c2.Name);
                    Console.WriteLine(c2.Surname);
                    Console.WriteLine(c2.Age);
                    Console.WriteLine(c2.EmployeeID);
                    Console.WriteLine(c2.Salary);
                    Console.ReadLine();
                    break;
                case "4":
                    Console.WriteLine("Yazılım Geliştiricileri Görüntülemektesiniz.");
                    Console.WriteLine(sd.Name);
                    Console.WriteLine(sd.Surname);
                    Console.WriteLine(sd.Age);
                    Console.WriteLine(sd.EmployeeID);
                    Console.WriteLine(sd.Salary);
                    Console.WriteLine("**************************************");
                    Console.WriteLine(sd1.Name);
                    Console.WriteLine(sd1.Surname);
                    Console.WriteLine(sd1.Age);
                    Console.WriteLine(sd1.EmployeeID);
                    Console.WriteLine(sd1.Salary);
                    Console.WriteLine("**************************************");
                    Console.WriteLine(sd2.Name);
                    Console.WriteLine(sd2.Surname);
                    Console.WriteLine(sd2.Age);
                    Console.WriteLine(sd2.EmployeeID);
                    Console.WriteLine(sd2.Salary);
                    Console.ReadLine();
                    break;
                case "5":
                    Console.WriteLine("İşçileri Görüntülemektesiniz.");
                    Console.WriteLine(w.Name);
                    Console.WriteLine(w.Surname);
                    Console.WriteLine(w.Age);
                    Console.WriteLine(w.EmployeeID);
                    Console.WriteLine(w.Salary);
                    Console.WriteLine("**************************************");
                    Console.WriteLine(w1.Name);
                    Console.WriteLine(w1.Surname);
                    Console.WriteLine(w1.Age);
                    Console.WriteLine(w1.EmployeeID);
                    Console.WriteLine(w1.Salary);
                    Console.WriteLine("**************************************");
                    Console.WriteLine(w2.Name);
                    Console.WriteLine(w2.Surname);
                    Console.WriteLine(w2.Age);
                    Console.WriteLine(w2.EmployeeID);
                    Console.WriteLine(w2.Salary);
                    Console.ReadLine();
                    break;
                case "6":
                        Console.WriteLine("Görmek istediğiniz yaşı giriniz.");
                    int yas = Convert.ToInt32(Console.ReadLine());
                    if (yas <= 18)
                    {
                        Console.WriteLine("Bu yaş aralığında personelimiz bulunmamaktadır.");
                    }
                    else if (yas <= 25)
                    {
                        Console.WriteLine("18-25 Yaş aralığındakileri görmektesiniz.");
                        Console.WriteLine(m.Name);
                        Console.WriteLine(m.Surname);
                        Console.WriteLine(m.Age);
                        Console.WriteLine(m.EmployeeID);
                        Console.WriteLine(m.Salary);
                        Console.WriteLine("**************************************");
                        Console.WriteLine(c1.Name);
                        Console.WriteLine(c1.Surname);
                        Console.WriteLine(c1.Age);
                        Console.WriteLine(c1.EmployeeID);
                        Console.WriteLine(c1.Salary);
                        Console.WriteLine("**************************************");
                        Console.WriteLine(c2.Name);
                        Console.WriteLine(c2.Surname);
                        Console.WriteLine(c2.Age);
                        Console.WriteLine(c2.EmployeeID);
                        Console.WriteLine(c2.Salary);
                        Console.WriteLine("**************************************");
                        Console.WriteLine(sd.Name);
                        Console.WriteLine(sd.Surname);
                        Console.WriteLine(sd.Age);
                        Console.WriteLine(sd.EmployeeID);
                        Console.WriteLine(sd.Salary);
                        Console.WriteLine("**************************************");
                        Console.WriteLine(sd1.Name);
                        Console.WriteLine(sd1.Surname);
                        Console.WriteLine(sd1.Age);
                        Console.WriteLine(sd1.EmployeeID);
                        Console.WriteLine(sd1.Salary);
                        Console.WriteLine("**************************************");
                        Console.WriteLine(sd2.Name);
                        Console.WriteLine(sd2.Surname);
                        Console.WriteLine(sd2.Age);
                        Console.WriteLine(sd2.EmployeeID);
                        Console.WriteLine(sd2.Salary);
                        Console.WriteLine("**************************************");
                        Console.WriteLine(w.Name);
                        Console.WriteLine(w.Surname);
                        Console.WriteLine(w.Age);
                        Console.WriteLine(w.EmployeeID);
                        Console.WriteLine(w.Salary);
                        Console.WriteLine("**************************************");
                        Console.WriteLine(w2.Name);
                        Console.WriteLine(w2.Surname);
                        Console.WriteLine(w2.Age);
                        Console.WriteLine(w2.EmployeeID);
                        Console.WriteLine(w2.Salary);
                        Console.ReadLine();
                    }
                    else if (yas <= 30)
                    {
                        Console.WriteLine("26-30 Yaş aralığındakileri görmektesiniz.");
                        Console.WriteLine(w1.Name);
                        Console.WriteLine(w1.Surname);
                        Console.WriteLine(w1.Age);
                        Console.WriteLine(w1.EmployeeID);
                        Console.WriteLine(w1.Salary);
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("31 yaşından büyükleri görmektesiniz.");
                        Console.WriteLine(m1.Name);
                        Console.WriteLine(m1.Surname);
                        Console.WriteLine(m1.Age);
                        Console.WriteLine(m1.EmployeeID);
                        Console.WriteLine(m1.Salary);
                        Console.WriteLine("**************************************");
                        Console.WriteLine(m2.Name);
                        Console.WriteLine(m2.Surname);
                        Console.WriteLine(m2.Age);
                        Console.WriteLine(m2.EmployeeID);
                        Console.WriteLine(m2.Salary);
                        Console.ReadLine();
                    }
                    break;
                case "7":
                    Console.WriteLine("Veri tabanından çıkılıyor");
                    Console.WriteLine("İyi Günler");
                    Console.ReadLine();
                    break;
            }


        }
    }
    interface IEmployee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int EmployeeID { get; set; }
        public int Salary { get; set; }
        public int Age { get; set; }
    }
    class Employee : IEmployee
    {
        public Employee(string name, string surname, int employeeId, int salary, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.EmployeeID = employeeId;
            this.Salary = salary;
            this.Age = age;
        }
        public string Name { get; set; }
        public string Surname { get ; set; }
        public int EmployeeID { get ; set; }
        public int Salary { get ; set ; }
        public int Age { get; set ; }
    }
    class Managers : Employee
    {
        public Managers(string name, string surname, int employeeId, int salary, int age) : base(name, surname, employeeId, salary, age)
        {

        }
    }
    class Chiefs : Employee
    {
        public Chiefs(string name, string surname, int employeeId, int salary, int age) : base(name, surname, employeeId, salary, age)
        {

        }
    }
    class SoftwareDevelopers : Employee
    {
        public SoftwareDevelopers(string name, string surname, int employeeId, int salary, int age) : base(name, surname, employeeId, salary, age)
        {

        }
    }
    class Workers : Employee
    {
        public Workers(string name, string surname, int employeeId, int salary, int age) : base(name, surname, employeeId, salary, age)
        {

        }
    }
}