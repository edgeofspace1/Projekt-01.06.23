class Program
{
    static void Main()
    {
        Console.WriteLine("Witaj w grze THIEF");
        Console.WriteLine("Twoim zadaniem bedzie zlupienie fortecy lorda ktory naslal na ciebie zbirow");
        Console.WriteLine("Musisz zdobyc mimimum 1000 zlota i uciec z zamku");

        Console.WriteLine("Tworzenie postaci...");
        Console.Write("Podaj imie zlodzieja: ");
        string name = Console.ReadLine();
        int gold = 0;
        int strzaly = 10;
        int wytrychy = 5;
        int health = 100;
        int wyjscie1 = 0;
        int lajfrip = 0;
        int przegrana1 = 0;
        while (health > 0)
        {
            Console.WriteLine("\nCo chcesz zrobic?");
            Console.WriteLine("1.Eksploruje fortece");
            Console.WriteLine("1.Opuszczam gre");
            int choice = int.Parse(Console.ReadLine());
            // Wykonanie wybranej przez gracza akcji
            if (choice == 1)
            {

                // Przygoda
                Console.WriteLine("\nPrzesukuję fortecę...");
                Random rnd = new Random();
                int wyw = rnd.Next(1, 101);
                if (wyw >= 1 && wyw <= 20)
                {
                    Console.WriteLine("Dostajesz się do pokoju");
                    Console.WriteLine("\nSkradając się dostrzegasz 3 strażników");
                    Console.WriteLine("Po dłuższych oględzinach pokoju zauważasz self z zamkiem");
                    Console.WriteLine("W sejfie muszą znajdować się wielkie bogactwa. Co postanawiasz zrobić?");
                    Console.WriteLine("1. Zakradam się do następnych pokoi (Powodzenie: 100%)");
                    Console.WriteLine("2. Okradam sejf wytrychem licząc, że nikt nie zauważy (Powodzenie: 30%)");
                    int wyb1 = int.Parse(Console.ReadLine());
                    if (wyb1 == 1)
                    {
                        Console.WriteLine("Przechodzenie pomieszczenia...");
                    }
                    if (wyb1 == 2)
                    {
                        int wy1 = rnd.Next(1, 101);
                        if (wy1 >= 1 && wy1 <= 30)
                        {
                            Console.WriteLine(" Złamano wytrych, ale pomyślnie zrabowano sejf! + 124 złota - 1 wytrych");
                            gold = gold + 124;
                            wytrychy = wytrychy - 1;
                            Console.WriteLine("Niepostrzeżenie przechodzę do następnego pokoju...");
                        }
                        if (wy1 >= 31 && wy1 <= 101)
                        {
                            Console.WriteLine("Przyłapano cię na kradzieży!");
                            Console.WriteLine("Nie miałeś szans przeciwstawieniu się 3 ochroniażom w kolczugach");
                            Console.WriteLine("KONIEC GRY!");
                            break;
                        }
                    }
                }
                if (wyw >= 21 && wyw <= 30)
                {
                    Console.WriteLine("Trafiasz na boczne wyjście z zamku");
                    Console.WriteLine("Nie potrzebujesz wytrychów aby wyjść");
                    Console.WriteLine("Czy chcesz zakończyć grę i przejść do podsumowania?");
                    Console.WriteLine("1. Tak");
                    Console.WriteLine("2. Nie");
                    int wyb2 = int.Parse(Console.ReadLine());
                    if (wyb2 == 1)
                    {
                        if (gold >= 1000)
                        {
                            Console.WriteLine("Wygrałeś grę okradając 1000 sztuk złota!");
                            break;
                        }
                        if (gold <= 1000)
                        {
                            Console.WriteLine("Nie udało ci się osiągnąć celu pieniężnego - PRZEGRANA");
                            break;
                        }
                        if (wyb2 == 2)
                        {
                            Console.WriteLine("Przechodzenie pomieszczenia...");
                        }
                    }


                }
                if (wyw >= 31 && wyw <= 50)
                {
                    Console.WriteLine("\nZnajdujesz się w niewielkim pomieszczeniu mieszkalnym");
                    Console.WriteLine("Na biurku znajdujesz mieszek ze złotem +14 złota oraz niewielką szkatułkę");
                    Console.WriteLine("Czy chcesz spróbować otworzyć zamek?");
                    Console.WriteLine("1. Tak (50% szans na złamanie wytrycha)");
                    Console.WriteLine("1. Nie (100% szans na pójście do następnego pokoju)");
                    int odg = int.Parse(Console.ReadLine());
                    if (odg == 1)
                    {
                        if (wytrychy >= 1)
                        {
                            int wy2 = rnd.Next(1, 101);
                            if (wy2 >= 1 && wy2 <= 50)
                            {
                                Console.WriteLine("Otwarto zamek! + 49 złota");
                                gold = gold + 49;
                            }
                            if (wy2 >= 51 && wy2 <= 101)
                            {
                                Console.WriteLine("Złamano wytrych!");
                                wytrychy = wytrychy - 1;
                                Console.WriteLine("Otwieranie kufra zajęło ci zbyt dużo czasu.");
                                Console.WriteLine("Pod drzwiami widać cień dwojga stróży.");
                                Console.WriteLine("Postanawiasz wrócić się i pójść do następnego pokoju.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Brak wytrychów!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Przechodzenie pomieszczenia...");
                    }

                }
                if (wyw >= 51 && wyw <= 70)
                {
                    Console.WriteLine("\nZakradłeś się do dużego magazynu");
                    Console.WriteLine("Po krótkich oględzinach dostrzegasz dwóch strażników oraz kilka beczek i kufrów");
                    Console.WriteLine("Czy chcesz teraz zrobić?");
                    Console.WriteLine("1. Atakuje strażników (Powodzenie: ???)");
                    Console.WriteLine("2. Staram się w ciemności zakraść do beczek i kufrów w świadomości, że mogę zostać zauważony (Powodzenie 40%)");
                    Console.WriteLine("1. Szukam bezpieczniejszych pomieszczeń (Opuszczam magazyn) (Powodzenie 80%)");
                    int odp = int.Parse(Console.ReadLine());
                    if (odp == 1)
                    {
                        int atk1 = rnd.Next(1, 120);
                        Console.WriteLine("\nPokonałeś strażników, ale straciłeś zdrowie!");
                        health = health - atk1;
                        if (health <= 0)
                        {
                            Console.WriteLine("NIE ŻYJESZ - KONIEC GRY!");
                            break;
                        }
                        Console.WriteLine("Pokonawszy wrogów zabierasz im klucze i otwierasz wszystkie zamki w magazynie po kolei");
                        int golt = rnd.Next(1, 400);
                        gold = gold + golt;
                    }
                    if (odp == 2)
                    {
                        int atk2 = rnd.Next(1, 200);
                        int wyt2 = rnd.Next(1, 101);
                        int wyt3 = rnd.Next(1, 101);
                        if (wyt2 >= 1 && wyt2 <= 40)
                        {
                            Console.WriteLine("Pomyślnie okradziono magazyn, lecz stracono wytrychy!");
                            int golt2 = rnd.Next(1, 200);
                            wytrychy = wytrychy - 2;
                            Console.WriteLine("Niepostrzeżenie przechodzę do następnego pokoju...");
                        }
                        if (wyt2 >= 31 && wyt2 <= 101)
                        {
                            Console.WriteLine("Przyłapano cię na kradzieży!");
                            Console.WriteLine("Co robisz?");
                            Console.WriteLine("1. Walczę! (Powodzenie 50%)");
                            Console.WriteLine("2. Uciekam! (Udana próba to opuszczenie gry i przejście do podsumowania) (Powodzenie 20%)");
                            int odw = int.Parse(Console.ReadLine());
                            if (odw == 1)
                            {
                                Console.WriteLine("Wdałeś się walkę, pokonałeś strażników lecz straciłeś dużo hp");
                                health = health - atk2;
                                if (health <= 0)
                                {
                                    Console.WriteLine("NIE ŻYJESZ - KONIEC GRY!");
                                    break;
                                }
                                Console.WriteLine("Pokonawszy wrogów zabierasz im klucze i otwierasz wszystkie zamki w magazynie po kolei");
                                int golt = rnd.Next(1, 400);
                                gold = gold + golt;
                            }
                            if (odw == 2)
                            {
                                if (wyt3 >= 1 && wyt3 <= 20)
                                {

                                }
                                if (wyt3 >= 20 && wyt3 <= 101)
                                {
                                    Console.WriteLine("Nieudana próba ucieczki - PRZEGRYWASZ");
                                    break;
                                }

                            }

                        }
                    }
                    if (odp == 3)
                    {
                        int wyt4 = rnd.Next(1, 101);
                        if (wyt4 >= 1 && wyt4 <= 80)
                        {
                            break;
                        }

                    }
                }
                if (wyw >= 71 && wyw <= 85)
                {
                    Console.WriteLine("\nWykryto pomieszczenie");
                    Console.WriteLine("\nZnaleziono notatki oraz mieszki ze złotem");
                    Console.WriteLine("\nPo krótkiej chwili ktoś wchodzi do pokoju");
                    Console.WriteLine("\nCo robisz?");
                    Console.WriteLine("\n1. Czekam");
                    Console.WriteLine("\n2. Atakuje (Powodzenie 60%)");
                    Console.WriteLine("\n3. Uciekam");
                    int odp = int.Parse(Console.ReadLine());
                    if (odp == 1)
                    {
                        Console.WriteLine("Czekanie opłaciło się! strażnik wyszedł, zdobyto złoto");
                        int golm = rnd.Next(1, 200);
                        gold = gold + golm;
                    }
                    if (odp == 2)
                    {
                        Console.WriteLine("Jak chcesz zaatakować strażnika?");
                        Console.WriteLine("1. Zastrzelić z łuku (90% powodzenia, bonus złota: 0)");
                        Console.WriteLine("2. Zaatakować mieczem (40% powodzenia, bonus złota: 300-500");
                        int odp3 = int.Parse(Console.ReadLine());
                        if (odp3 == 1)
                        {
                            int strz = rnd.Next(1, 100);
                            if (strz >= 0 && strz <= 90)
                            {
                                Console.WriteLine("Pokonawszy strażnika okradasz pomieszczenie, zdobyto złoto");
                                int golm2 = rnd.Next(1, 200);
                                gold = gold + golm2;

                            }
                            if (strz >= 90 && strz <= 100)
                            {
                                Console.WriteLine("Nie udało się trafić strażnika, po zorientowaniu się wezwał on posiłki");
                                Console.WriteLine("PRZEGRANA!");
                            }
                        }
                        if (odp3 == 2)
                        {
                            int micz = rnd.Next(1, 100);
                            int bons = rnd.Next(300, 500);
                            int atk5 = rnd.Next(1, 50);
                            if (micz >= 0 && micz <= 40)
                            {
                                Console.WriteLine("Pokonawszy strażnika okradasz pomieszczenie, zdobyto złoto + bonus");
                                gold = gold + bons;
                            }
                            if (micz >= 41 && micz <= 100)
                            {
                                Console.WriteLine("Straciłeś zdrowie ale pokonałeś wroga, zdobyto złoto + bonus");
                                gold = gold + bons;
                                health = health - atk5;
                                if (health <= 0)
                                {
                                    Console.WriteLine("NIE ŻYJESZ - KONIEC GRY!");
                                    break;
                                }
                            }

                        }

                    }
                    if (odp == 3)
                    {
                        Console.WriteLine("Udało ci się uciec niepostrzeżenie, niestety podczas ucieczki straciłeś trochę złota!");
                        int gont = rnd.Next(1, 100);
                        gold = gold - gont;
                    }

                }
                if (wyw >= 86 && wyw <= 101)
                {
                    Console.WriteLine("Nie natrafiasz na żadne pomieszczenie! Korytarz ciągnie się dalej...");
                }



            }
            if (choice == 2)
            {
                break;
            }

        }

    }

}