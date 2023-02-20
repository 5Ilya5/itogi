static void Main();
{
            // Процесс получения ссылки на объект RegistryKey называется открытием ключа.
            RegistryKey myKey = Registry.ClassAnimal;
            RegistryKey information = myKey.OpenSubKey("information");
            RegistryKey animal = software.OpenSubKey("animal");
 
            Console.WriteLine("{0} - всего элементов: {1}.", animal.Name, animal.SubKeyCount);
            animal.Close();
 
            // Попытка открыть несуществующий ключ. Переменной будет присвоено значение NULL.
            information = myKey.OpenSubKey("nookery");
 
            // В блоке try совершается попытка обратится к переменной, значение которой не присвоено.
            try
            {
                Console.WriteLine("Открыли узел: {0}.", information.Name);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.GetType());
            }
 
            // Задержка на экране.
            Console.ReadKey();
        }