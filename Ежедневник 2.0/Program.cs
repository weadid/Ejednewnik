namespace Ежедневник_2._0
{
    internal class Program
    {
        static void Main()
        {
            Note note = new Note();
            note.title = "  1. Найти попугая";
            note.tite = "  Подробности: попугай улетел в 3 часа ночи, найди его ";
            note.created = new DateTime(2022, 10, 16);
            
            Note note2 = new Note();
            note2.title = "  2. Два котика сидят и ждут еды";
            note2.tite = "  Подробности: покормить котиков ";
            note2.created = new DateTime(2022, 10, 16);
            
            Note note3 = new Note();
            note3.title = "  3. Олень голубой решить";
            note3.tite = "  Подробности: пройти олимпиаду ";
            note3.created = new DateTime(2022, 10, 16);
            
            Note note4 = new Note();
            note4.title = "  4. Помыть собаку";
            note4.tite = "  Подробности: взять шампунь, уточек и полотенце ";
            note4.created = new DateTime(2022, 10, 16);

            Note note5 = new Note();
            note5.title = "  5. Спасти мир";
            note5.tite = "  Подробности: ты человек паук, тебя ждут";
            note5.created = new DateTime(2022, 10, 16);

            Note note6 = new Note();
            note6.title = "  1. Сходить в магазин";
            note6.tite = "  Подробности: купить макароны, медведей, бананы и молоко ";
            note6.created = new DateTime(2022, 10, 20);

            Note note7 = new Note();
            note7.title = "  2. Помыть посуду";
            note7.tite = "  Подробности: на первом этаже и втором ";
            note7.created = new DateTime(2022, 10, 20);

            Note note8 = new Note();
            note8.title = "  3. Завтрак чемпиона";
            note8.tite = "  Подробности: приготовить сосиски с омлетом ";
            note8.created = new DateTime(2022, 10, 20);

            Note note9 = new Note();
            note9.title = "  4. Кенгуру";
            note9.tite = "  Подробности: решить олимпиаду ";
            note9.created = new DateTime(2022, 10, 20);

            Note note10 = new Note();
            note10.title = "  5. Посмотреть 'Время'";
            note10.tite = "  Подробности: Позвать Андрея на кино ";
            note10.created = new DateTime(2022, 10, 20);

            Note note11 = new Note();
            note11.title = "  1. Прийти на пару";
            note11.tite = "  Подробности: на все прийти ";
            note11.created = new DateTime(2022, 10, 22);

            Note note12 = new Note();
            note12.title = "  2. Сходить в магазин";
            note12.tite = "  Подробности: купить макароны, медведей, бананы и молоко ";
            note12.created = new DateTime(2022, 10, 22);

            Note note13 = new Note();
            note13.title = "  3. Прийти домой  через мост";
            note13.tite = "  Подробности: идти надо долго ";
            note13.created = new DateTime(2022, 10, 22);

            Note note14 = new Note();
            note14.title = "  4. Приготовить кушать";
            note14.tite = "  Подробности: сегодня у нас ужин ";
            note14.created = new DateTime(2022, 10, 22);

            Note note15 = new Note();
            note15.title = "  5. Приготоваиться ко сну";
            note15.tite = "  Подробности: помыться, взять медведя ";
            note15.created = new DateTime(2022, 10, 22);

            List<Note> notes = new List<Note>();
            notes.Add(note);
            notes.Add(note2);
            notes.Add(note3);
            notes.Add(note4);
            notes.Add(note5);
            notes.Add(note6);
            notes.Add(note7);
            notes.Add(note8);
            notes.Add(note9);
            notes.Add(note10);
            notes.Add(note11);
            notes.Add(note12);
            notes.Add(note13);
            notes.Add(note14);
            notes.Add(note15);


            DateTime date = DateTime.Now;
            int position = 1;
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key == ConsoleKey.RightArrow)
                {
                    date = date.AddDays(1);
                }
                else if (key.Key == ConsoleKey.LeftArrow)
                {
                    date = date.AddDays(-1);
                }
                Console.Clear();

                Console.WriteLine("Выбрана дата: " + date.ToShortDateString());
                for (int i = 0; i < notes.Count; i++)
                {
                    if (notes[i].created.Date == date.Date)
                    {
                        Console.WriteLine(notes[i].title);
                        if (key.Key == ConsoleKey.Enter)
                        {
                            Console.Clear();
                            Console.WriteLine(notes[i].title);
                            Console.WriteLine("--------------------------------");
                            Console.WriteLine(notes[i].tite);
                            Console.WriteLine("  Дата: " + notes[i].created);
                        }
                    }
                }
                /*for (int i = 0; i < notes.Count; i++)
                {
                    if (notes[i].created.Date == date.Date)
                    {
                        Console.WriteLine(notes[i].title);
                        foreach (Note a in notes)
                        {

                            if (key.Key == ConsoleKey.Enter)
                            {
                                Console.WriteLine(notes[position].title);
                                Console.WriteLine("--------------------------------");
                                Console.WriteLine(notes[position].tite);
                                Console.WriteLine("  Дата: " + notes[position].created);
                            }


                        }

                    }
                }*/
                position = Strelka(key, position);
            }
        }



        static int Strelka(ConsoleKeyInfo key, int position)
        {
            if (key.Key == ConsoleKey.UpArrow)
            {
                position--;

            }
            if (key.Key == ConsoleKey.DownArrow)
            {
                position++;

            }
            Console.SetCursorPosition(0, position);
            Console.WriteLine("->");

            return position;
        }
    }
}