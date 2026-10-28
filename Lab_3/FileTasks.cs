using System;
using System.IO;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    public struct Toy
    {
        private string _name;
        private double _price;
        private int _minAge;
        private int _maxAge;
        
        public Toy(string name, double price, int minAge, int maxAge)
        {
            _name = name;
            _price = price;
            _minAge = minAge;
            _maxAge = maxAge;
        }
        
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public int MinAge
        {
            get { return _minAge; }
            set { _minAge = value; }
        }

        public int MaxAge
        {
            get { return _maxAge; }
            set { _maxAge = value; }
        }
        
        public override string ToString()
        {
            return $"{_name}, {_price} руб., возраст: от {_minAge} до {_maxAge} лет";
        }
    }

    internal class FileTasks
    {
        private static void FillBinaryFile(string fileName, int elementCount)
        {
            Random random = new Random();
            
            using (FileStream fileStream = new FileStream(fileName, FileMode.Create))
            using (BinaryWriter binaryWriter = new BinaryWriter(fileStream))
            {
                for (int i = 0; i < elementCount; i++)
                {
                    binaryWriter.Write(random.Next(-100, 100));
                }
            }
        }

        public static void Task4()
        {
            string fileName = "task4.bin";
            FillBinaryFile(fileName, 10);

            using (FileStream fileStream = new FileStream(fileName, FileMode.Open))
            using (BinaryReader binaryReader = new BinaryReader(fileStream))
            {
                if (fileStream.Length == 0)
                {
                    Console.WriteLine("Файл пуст.");
                    return;
                }

                int firstElement = binaryReader.ReadInt32();
                int maxElement = firstElement;

                Console.Write("Элементы файла: ");
                Console.Write($"{firstElement} ");

                while (binaryReader.BaseStream.Position < binaryReader.BaseStream.Length)
                {
                    int currentElement = binaryReader.ReadInt32();
                    Console.Write($"{currentElement} ");

                    if (currentElement > maxElement)
                    {
                        maxElement = currentElement;
                    }
                }

                Console.WriteLine();
                Console.WriteLine($"Первый элемент: {firstElement}");
                Console.WriteLine($"Максимальный элемент: {maxElement}");
                Console.WriteLine($"Разность первого и максимального: {firstElement - maxElement}");
            }
        }

        private static void FillToyFile(string fileName, Checked c)
        {
            int toyCount = c.ReadIntInRange("Сколько игрушек вы хотите добавить? ", 1, 20);
            Toy[] toys = new Toy[toyCount];

            for (int i = 0; i < toyCount; i++)
            {
                Console.WriteLine($"\nВвод игрушки #{i + 1}:");
        
                string name = c.ReadString("Название: ");
                double price = c.ReadDouble("Цена: ");
                int minAge = c.ReadIntInRange("Минимальный возраст: ", 0, 18);
                int maxAge = c.ReadIntInRange("Максимальный возраст: ", minAge, 18);

                toys[i] = new Toy(name, price, minAge, maxAge);
            }

            XmlSerializer serializer = new XmlSerializer(typeof(Toy[]));

            using (FileStream fileStream = new FileStream(fileName, FileMode.Create))
            {
                serializer.Serialize(fileStream, toys);
            }
        }

        public static void Task5(Checked c)
        {
            string fileName = "task5.xml";
            FillToyFile(fileName, c);

            XmlSerializer serializer = new XmlSerializer(typeof(Toy[]));
            Toy[] toys;

            using (FileStream fileStream = new FileStream(fileName, FileMode.Open))
            {
                toys = (Toy[])serializer.Deserialize(fileStream);
            }

            Console.WriteLine("\nИгрушки, подходящие для 6 лет (только Куклы):");
    
            bool found = false;
            foreach (Toy toy in toys)
            {
                if (toy.Name.ToLower() == "кукла" && toy.MinAge <= 6 && toy.MaxAge >= 6)
                {
                    Console.WriteLine(toy);
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("Кукол для шестилетних детей не найдено.");
            }
        }
    }
}