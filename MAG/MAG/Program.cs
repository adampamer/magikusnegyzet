using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_challange
{
    class Program
    {
        static void Main(string[] args)
        {
            const int tomb = 10;

            int[] tombfo = new int[tomb];
            int[] tombme = new int[tomb];
            int randt = 0;
            int[,] matrix = new int[tomb, tomb];
            double[] hely = new double[tomb];
            double[] hely2 = new double[tomb];
            double[] tomb2 = new double[tomb];
            double[] tomb3 = new double[tomb];
            double[] tombs = new double[tomb];
            int osszeg = 0, osszeg2=0,osszeg3=0,osszeg4=0,osszeg5=0,osszeg6=0;
            int atl = 0;
            int atl2 = 0,fo2=0,fo2s=0;
            int oszlop1 = 0, oszlop2 = 0, fo = 0 ,fos=0;
            int sor1 = 0, sor2 = 0;
            int randert = 0, randtombert = 0;
            int p = 0, dm = 0, csere1=0, csere2, csere3, csere4;
            Random szamok = new Random();
            do
            {
                for (int i = 0; i <tomb;i++)
                {
                    tomb2[i] = 30;
                    tomb3[i] = 30;
                }
                do
                {                                                         // Random szám generálás
                    randt = 30;
                    
                    p = 0;
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            matrix[i, j] = randt;
                        }
                    }
                    randert = szamok.Next(1, tomb);
                    randtombert = szamok.Next(1, tomb);
                    

                   /* if (tomb % 2 == 0)
                    {

                        tombs[1] = tomb / 2;
                        if (tombs[1] % 2 == 0)
                        {
                            tombs[2] = tomb / 2;
                        }
                        else
                        {
                            
                            t = tomb / 2;
                            tombs[2] = t - 0.5;
                            tombs[3] = t + 0.5;
                            t = 0;
                             
                        }

                    }
                    else
                    {
                      t = tomb / 2;
                        tombs[1]=t-0.5;
                        tombs[2] = t + 0.5;
                        t = 0;


                    }*/
                    do
                    {
                        p++;
                        //max = 0;
                        //randert = 0;

                        oszlop1 = szamok.Next(0, tomb);
                        sor1 = szamok.Next(0, tomb);
                        oszlop2 = szamok.Next(0, tomb);
                        sor2 = szamok.Next(0, tomb);
                        fo = szamok.Next(0, tomb);
                        fos = szamok.Next(0, tomb);
                      
                      /*  for (int i = 0; i < tomb; i++)
                        {
                            for (int i2 = 0; i2 < tomb; i2++)
                            {
                                do
                                {
                                    if (fo2 + fo2s >= tomb - 1)
                                    {
                                        if (fo2 < tomb && fo2 > 0)
                                        {
                                            fo2 -= 1;
                                        }
                                        else
                                        {
                                            fo2 += 1;
                                        }

                                    }
                                    else if (fo2 + fo2s <= tomb - 1)
                                    {
                                        if (fo2s < tomb && fo2s > 0)
                                        {
                                            fo2s -= 1;
                                        }
                                        else
                                        {
                                            fo2s += 1;
                                        }


                                    }
                                } while (fo2 + fo2s != tomb - 1 && fo2 < tomb && fo2 > 0 && fo2s < tomb && fo2s > 0);
                            }
                        }*/
                       
                        //for (int i = 0; i < 4; i++)
                        //{
                            
                        //}

                        if (randert < matrix[oszlop1, sor1] && randert < matrix[oszlop2, sor2] && randert < matrix[oszlop1, sor2] && randert < matrix[oszlop2, sor1] && oszlop2 != sor1 && oszlop2 != sor2 && oszlop1 != sor2 && oszlop1 != sor1 && oszlop2 + sor1 != tomb - 1 && oszlop2 + sor2 != tomb - 1 && oszlop1 + sor2 != tomb - 1 && oszlop1 + sor1 != tomb - 1)
                        {

                            matrix[oszlop2, sor1] -= randert;
                            matrix[oszlop2, sor2] += randert;
                            matrix[oszlop1, sor1] += randert;
                            matrix[oszlop1, sor2] -= randert;

                        }
                        else if(randert < matrix[oszlop1, sor1] && randert < matrix[oszlop2, sor2] && randert < matrix[oszlop1, sor2]&& randert < matrix[oszlop2, sor1])
                        {
                            matrix[oszlop2, sor1] -= randert;
                            matrix[oszlop2, sor2] += randert;
                            matrix[oszlop1, sor1] += randert;
                            matrix[oszlop1, sor2] -= randert;
                            /*for (int i = 0; i < tomb; i++)
                            {
                                for (int i2 = 0; i2 < tomb; i2++)
                                {
                                    hely[i] += matrix[i, i2];
                                    hely2[i] += matrix[i2, i];
                                    if (i == i2)
                                    {
                                        osszeg += matrix[i, i2];
                                    }
                                    if (i + i2 == tomb - 1)
                                    {
                                        osszeg2 += matrix[i, i2];
                                    }
                                }
                            }*/


                        }
                        csere1 = szamok.Next(0, (tomb) / 4);
                        csere2 = (tomb-1) / 2 - csere1;
                        csere3 = (tomb - 1) - csere2;
                        csere4 = (tomb - 1) - csere1;
                        if (randtombert < matrix[oszlop1, sor1] && randtombert < matrix[oszlop2, sor2] && randtombert < matrix[oszlop1, sor2] && randtombert < matrix[oszlop2, sor1])
                        {

                             
                            /*tombfo[csere1] -= fo;
                        tombme[csere1] += fo;
                        tombfo[csere1] -= fo;
                        tombme[csere1] += fo;
                        tombfo[csere2] += fo;
                        tombme[csere2] -= fo;
                        tombfo[csere2] += fo;
                        tombme[csere2] -= fo;*/
                       

                        }
                        
                       
                      
                        

                    } while (p <= tomb*50);


                    /* for (int i = 0; i < 10; i++)              
                     {
                         for (int j = 0; j < 10; j++)
                         {
                             if (matrix[i, j] == 1 && db == 0) // sor
                             {
                                 db++;
                             }
                             else
                             {
                                 matrix[i, j] = 0;
                             }
                             if (matrix[j, i] == 1 && hdb == 0) // Oszlop
                             {
                                 hdb++;
                             }
                             else
                                 matrix[j, i] = 0;
                    
                         }
                         db = 0;
                         hdb = 0;
                      }*/
                   
                    dm++;
                } while (dm < 5000);
                for (int i = 0; i < tomb; i++)
                {
                    tombfo[i] = matrix[i, i];
                 
                }
                int k = tomb;
                for (int i = 0; i < tomb; i++)
                {
                    k--;
                    tombme[i] = matrix[i, k];
                }
               
                for (int i = 0; i < tomb; i++)
                {
                    Console.Write(tombfo[i]+",");
                }

                Console.WriteLine();

                for (int i = 0; i < tomb; i++)
                {
                    Console.Write(tombme[i] + ",");
                }
                Console.WriteLine();
                Console.WriteLine(csere1+" "+ csere2+" "+csere3+" "+csere4);
                Console.WriteLine();
                
                for (int i = 0; i < tomb; i++)
                {
                    matrix[i, i] = tombfo[i];
                }
                k = tomb;
                for (int i = 0; i < tomb; i++)
                {
                    k--;
                    matrix[i, k] = tombme[i];
                }
                for (int i = 0; i < tomb; i++)
                {
                    for (int i2 = 0; i2 < tomb; i2++)
                    {
                        hely[i] += matrix[i, i2];
                        hely2[i] += matrix[i2, i];
                        if(i==i2)
                        {
                            atl2 += matrix[i, i2];
                        }
                        if (i + i2 == tomb - 1)
                        {
                            atl += matrix[i, i2];
                        }
                    }
                }
                osszeg2=atl;
                osszeg3 = atl2;
                double o = 0;
                double o2 = 0;
                if (tomb * randt < osszeg2)
                {
                    osszeg = osszeg2 - tomb * randt;
                    if(osszeg%2==0)
                    {
                        o = osszeg / 2;

                    }
                    else
                    {
                        o = osszeg5 / 2;
                        o = Math.Round(o2, 0);
                        o2 = o2 + 1;
                    }

                    int y = 1;
                        
                                    

                                    for (int i3 = 2; i3 <= 3; i3++)
                                    {
                                        if (tombme[i3] > tombme[y])
                                        {

                                            y = i3;

                                        }

                                    }
                                    if (osszeg5 % 2 == 0)
                                    {
                                        tombme[y] -= Convert.ToInt32(o);
                                        tombme[y - 1] -= Convert.ToInt32(o);
                                    }
                                    else
                                    {
                                        tombme[y] -= Convert.ToInt32(o);
                                        tombme[y - 1] -= Convert.ToInt32(o2);
                                    }
                    
                                        for (int i = 0; i < tomb; i++)
                                        {
                                            for (int i2 = 0; i2 < tomb; i2++)
                                            {
                                                if (i + i2 == tomb - 1)
                                                {
                                                     matrix[i, i2]=tombme[i2];
                                                }
                                            }
                                        }
                                        
                        for (int i = 0; i < tomb; i++)
                        {
                            Console.Write(tombme[i]+",");
                            
                        }
                    Console.WriteLine();
                }
                
                else if (tomb * randt > osszeg2)
                {
                    osszeg =   tomb * randt-osszeg2;
                    int y = 1;
                    for (int i3 = 2; i3 <= 3; i3++)
                    {
                        if (tombme[i3] < tombme[y])
                        {

                            y = i3;

                        }

                    }

                    tombme[y] += osszeg;
                         
                    for (int i = 0; i < tomb; i++)
                    {
                        for (int i2 = 0; i2 < tomb; i2++)
                        {
                            if (i + i2 == tomb - 1)
                            {
                                matrix[i, i2] = tombme[i2];
                            }
                        }
                    }
                   
                }
                double o3=0;
                double o4 = 0;
                if (tomb * randt < osszeg3)
                {
                    osszeg5 = osszeg3 - tomb * randt;
                    if (osszeg5 % 2 == 0)
                    {
                        o4 = osszeg5 / 2;

                    }
                    else
                    {
                        o4 = osszeg5 / 2;
                        o4 = Math.Round(o4,0);
                        o3 = o4 + 1;
                    }
                    int y = 1;



                    for (int i3 = 2; i3 <= 3; i3++)
                    {
                        if (tombfo[i3] > tombfo[y])
                        {

                            y = i3;

                        }

                    }

                    if (osszeg5 % 2 == 0)
                    {
                        tombfo[y] -= Convert.ToInt32(o4);
                        tombfo[y - 1] -= Convert.ToInt32(o4);
                    }
                    else
                    {
                        tombfo[y] -= Convert.ToInt32(o4);
                        tombfo[y - 1] -= Convert.ToInt32(o3);
                    }
                    
                    for (int i = 0; i < tomb; i++)
                    {
                        for (int i2 = 0; i2 < tomb; i2++)
                        {
                            if (i == i2 )
                            {
                                matrix[i, i2] = tombfo[i2];
                            }
                        }
                    }

                    for (int i = 0; i < tomb; i++)
                    {
                        Console.Write(tombfo[i] + ",");

                    }

                    Console.WriteLine();
                }
                else if (tomb * randt > osszeg3)
                {
                    osszeg5 = tomb * randt - osszeg3;
                    int y = 1;
                    for (int i3 = 2; i3 <= 3; i3++)
                    {
                        if (tombfo[i3] < tombfo[y])
                        {

                            y = i3;

                        }

                    }
                    tombfo[y] += osszeg5;

                    for (int i = 0; i < tomb; i++)
                    {
                        for (int i2 = 0; i2 < tomb; i2++)
                        {
                            if (i == i2 )
                            {
                                matrix[i, i2] = tombfo[i2];
                            }
                        }
                    }

                }
                for (int i = 0; i < tomb; i++)               // Kiírjuk a mátrixban lévő értékeket
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write("{0:00} ", matrix[i, j]);
                    }
                    Console.WriteLine("____" + hely[i]);
                    Console.WriteLine();
                }
                for (int i = 0; i < tomb; i++)
                {
                    for (int i2 = 0; i2 < tomb; i2++)
                    {
                        if (i == i2)
                        {
                            osszeg6 += matrix[i, i2];
                        }
                        if (i + i2 == tomb - 1)
                        {
                            osszeg4 += matrix[i, i2];
                        }
                    }
                }
                Console.Write("{0},", osszeg4);
                for (int i = 0; i < tomb; i++)
                {
                    Console.Write(hely2[i] + ",");
                }
                Console.Write(osszeg6);
                Console.WriteLine(magikus_negyzet_e(matrix));
                Console.WriteLine("  " + fo2 + "  " + fo2s);
                Console.ReadKey();
                Console.Clear();

                for (int i = 0; i < tomb; i++)
                {
                    for (int i2 = 0; i2 < tomb; i2++)
                    {
                        hely[i] = 0;
                        hely2[i] = 0;
                    }
                }
                atl = 0;
                osszeg4 = 0;
                osszeg6 = 0;
                atl2 = 0;
               
            } while (true);
            
           
        }
      
        static bool magikus_negyzet_e(int[,] m)
        {
            
            int N = m.GetLength(0);
            int[] sorok = new int[N];
            int[] oszlopok = new int[N];
            osszegekGen(m, sorok, oszlopok);
            // sorok, oszlopok osszegei 
            if (mindEgyenlo(sorok) == false ||
               mindEgyenlo(oszlopok) == false ||
               sorok[0] != oszlopok[0]) return false;
            // atlok osszegei 
            int atlo1, atlo2;
            atlokGen(m, out atlo1, out atlo2);
            if (atlo1 != atlo2 || atlo1 != sorok[0])
                return false;
            // egyediseg 
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    if (megszamol(m, m[i, j]) != 1)
                        return false;
            // minden rendben 
            return true;
            
        }
        static void osszegekGen(int[,] m, int[] sorok, int[] oszlopok)
        {
            for (int i = 0; i < sorok.Length; i++)
                for (int j = 0; j < oszlopok.Length; j++)
                {
                    sorok[i] = sorok[i] + m[i, j];
                    oszlopok[j] = oszlopok[j] + m[i, j];
                }
        }
        static bool mindEgyenlo(int[] l)
        {
            int x = l[0];
            foreach (int a in l)
                if (x != a) return false;
            return true;
        }
        static void atlokGen(int[,] m, out int a, out int b)
        {
            a = 0; b = 0;
            int N = m.GetLength(0);
            for (int i = 0; i < N; i++)
            {
                a = a + m[i, i];
                b = b + m[i, N - i - 1];
            }
        }
        static int megszamol(int[,] m, int x)
        {
            int N = m.GetLength(0);
            int db = 0;
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    if (m[i, j] == x) db++;
            return db;
            
        }
          
    }
}
