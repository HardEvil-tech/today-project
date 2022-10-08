using sharp6;


Телефон телефон = new Телефон()
{
    Name = "Xiaomi",
    Zaryadka = 80,
    Sim = true
};

try
{
    телефон.MakeACall("+380950151059" );
}catch(Exception ex)
{
    Console.WriteLine("Щось пішло не так");
}

