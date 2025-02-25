using _30github.app.Application.Services;
using _30github.app.Domain.Entities;
using _30github.app.Infrastructure.Services;

namespace project
{

    class Program
    {

        static void Main()
        {
            Console.Write("Перевод строки – \n\n");

            // Строчный комментарий
            /*
                Огромный
                комментарий!
            */
            // Console.Write("Комментарий");
            Console.Write("Текст");

            int age = 45;
            string name = "A";
            bool isActive = false;
            decimal size = 178;
            float weight = 789;
            string? lastName = null;
            char symbol = 'd';

            float someValue = 4.56f;
            someValue = 67.5f;

            double otherValue = -786782.78f;

            short height = -30678;
            byte position = 255;
            long bigNumber = 9223372036854775807;

            // See https://aka.ms/new-console-template for more information
            Console.WriteLine("Hello, World!");
            Console.WriteLine(age);
            Console.WriteLine(name);
            Console.WriteLine(isActive);
            Console.WriteLine(size);
            Console.WriteLine(weight);
            Console.WriteLine(lastName);
            Console.WriteLine(someValue);
            Console.WriteLine(height);
            Console.WriteLine(position);
            Console.WriteLine(bigNumber);
            Console.WriteLine(otherValue);
            Console.WriteLine(symbol);

            Console.WriteLine(position - age);

            for (int i = 0; i < 5; i++)
                Console.WriteLine(i);

            // array
            char[] chars = new char[3];
            chars[0] = 'a';
            chars[1] = 'b';
            chars[2] = 'c';

            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            int[] y = { 1, 2, 3 };

            Console.WriteLine(chars);
            Console.WriteLine(numbers);
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            foreach (int num in y)
            {
                Console.WriteLine(num);
            }

            int[,,] x = { { { 1, 3 }, { 4, 5 } }, { { 1, 3 }, { 4, 5 } } };
            x[0, 1, 1] = 6;
            foreach (int num in x)
            {
                Console.WriteLine("num");
                Console.WriteLine(num);
            }

            List<string> words = new List<string>();
            words.Add("bingo");
            words.Add("major");

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            string currentDir = AppContext.BaseDirectory;
            string filePath = $"{currentDir}../../../storage/products.json";
            FileInfo fileInfo = new FileInfo(filePath);

            if (fileInfo.Exists)
            {
                string fileContent = File.ReadAllText(filePath);

                Console.WriteLine(fileContent);
                Console.WriteLine($"File name: {fileInfo.Name}");
            }

            FileStream fs = null;
            try
            {
                fs = new FileStream(filePath, FileMode.Open);
                StreamReader sr = new StreamReader(fs);

                string line;
                string nLine;

                line = sr.ReadLine();
                nLine = line;

                while (nLine != null)
                {
                    nLine = sr.ReadLine();
                    line += $"\n{nLine}";
                }

                Console.WriteLine(line);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("file not found");

                throw new FileNotFoundException(@"[data.txt не в c:	emp папке]", e);
            }
            finally
            {
                fs?.Close();
            }

            UserEntity user = new UserEntity();
            user.Name = "Aktan";
            Console.WriteLine(user.Name);

            ProductEntity product = new ProductEntity(78979872349234, "green-book", 6723f, "Green Book");
            Console.WriteLine(product.GetId());
            Console.WriteLine(product.GetHandle());
            Console.WriteLine(product.GetPrice());
            Console.WriteLine(product.GetTitle());

            AppleEntity appleEntity = new AppleEntity(782748792834, "apple-green", 7872f, "bingo", "Apple green - bingo");
            appleEntity.Variety = "bingo1";

            Console.WriteLine(appleEntity.Variety);

            // operator is & as
            Console.WriteLine(appleEntity is AppleEntity);

            AppleEntity? pear = null;
            AppleEntity? apple = null;
            apple = pear as AppleEntity;

            Console.WriteLine(apple is AppleEntity);

            SmartCollectionManager smartCollectionManager = new SmartCollectionManager();
            CollectionEntity collection = smartCollectionManager.GetById(87382947823);

            collection.Title = "smart-collection";

            Console.WriteLine(collection.Title);
            Console.WriteLine(collection.Type);

            UserMarketingService userMarketingService = new UserMarketingService();

            Console.WriteLine(userMarketingService.SmsMarketingConsent());

            Console.WriteLine(smartCollectionManager.GetBy(74827482948923));
            Console.WriteLine(smartCollectionManager.GetBy(74827482948923, "bingo-collection"));
            Console.WriteLine(smartCollectionManager.GetBy("smart"));
            Console.WriteLine(smartCollectionManager.ToString());

            // Получение данных
            Console.ReadLine();
        }

        public static void Print()
        {
            Console.WriteLine("");
        }
    }

}
