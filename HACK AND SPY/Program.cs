using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HACK_AND_SPY
{
    class Program
    {
        static void PANTALLADEINICIO()
        {
            Console.CursorVisible = false;
            int Y = 40;
            int X = 120;
            Console.SetWindowSize(X, Y);

            int x = 0;
            int y = 0;

            Console.ForegroundColor = ConsoleColor.Blue;
            for (y = 0; y < Y; y++)
            {
                Console.SetCursorPosition(0, y);
                Console.WriteLine("║");

            }
            for (x = 0; x < X; x++)
            {
                Console.SetCursorPosition(x, 0);
                Console.WriteLine("═");
            }
            for (y = 0; y < Y; y++)
            {
                Console.SetCursorPosition((X - 1), y);
                Console.WriteLine("║");

            }
            for (x = 0; x < X; x++)
            {
                Console.SetCursorPosition(x, (Y - 1));
                Console.WriteLine("═");
            }
            Console.SetCursorPosition(0, 0); //Superior izquierda
            Console.WriteLine("╔");
            Console.SetCursorPosition(0, (Y - 1)); //Inferior izquierda
            Console.WriteLine("╚");
            Console.SetCursorPosition((X - 1), 0); //Superior derecha
            Console.WriteLine("╗");
            Console.SetCursorPosition((X - 1), (Y - 1)); //Inferior derecha
            Console.WriteLine("╝");
            x = 23;
            y = 11;
            Console.SetCursorPosition(x, y);
            Thread.Sleep(30);
            Console.Write("██╗  ██╗ █████╗  ██████╗██╗  ██╗       ██╗       ███████╗██████╗ ██╗   ██╗");
            Console.SetCursorPosition(x, (y + 1));
            Thread.Sleep(30);
            Console.Write("██║  ██║██╔══██╗██╔════╝██║ ██╔╝       ██║       ██╔════╝██╔══██╗╚██╗ ██╔╝");
            Console.SetCursorPosition(x, (y + 2));
            Thread.Sleep(30);
            Console.Write("███████║███████║██║     █████╔╝     ████████╗    ███████╗██████╔╝ ╚████╔╝ ");
            Console.SetCursorPosition(x, (y + 3));
            Thread.Sleep(30);
            Console.Write("██╔══██║██╔══██║██║     ██╔═██╗     ██╔═██╔═╝    ╚════██║██╔═══╝   ╚██╔╝  ");
            Console.SetCursorPosition(x, (y + 4));
            Thread.Sleep(30);
            Console.Write("██║  ██║██║  ██║╚██████╗██║  ██╗    ██████║      ███████║██║        ██║   ");
            Console.SetCursorPosition(x, (y + 5));
            Thread.Sleep(30);
            Console.Write("╚═╝  ╚═╝╚═╝  ╚═╝ ╚═════╝╚═╝  ╚═╝    ╚═════╝      ╚══════╝╚═╝        ╚═╝   ");
            Console.SetCursorPosition(x, (y + 7));
            Thread.Sleep(60);
            Console.Write("╔════════════════════════════════════════════════════════════════════════╗");
            Console.SetCursorPosition(x, (y + 8));
            Thread.Sleep(60);
            Console.Write("║                                                                        ║");
            Console.SetCursorPosition(x, (y + 9));
            Thread.Sleep(60);
            Console.Write("╚════════════════════════════════════════════════════════════════════════╝");
            Thread.Sleep(100);
            Console.SetCursorPosition((x + 32), (y + 11));
            Console.Write("C A R G A N D O");
            Thread.Sleep(1000);
            for (int i = 0; i < 72; i++)
            {
                Console.SetCursorPosition((i + 24), (y + 8));
                Thread.Sleep(130);
                Console.Write("█");
            }
            Console.Clear();
        }
        static void PANTALLA()
        {
            int Y = 40;
            int X = 120;
            Console.SetWindowSize(X, Y);

            int x = 0;
            int y = 0;

            for (y = 0; y < Y; y++)
            {
                Console.SetCursorPosition(0, y);
                Console.WriteLine("║");

            }
            for (x = 0; x < X; x++)
            {
                Console.SetCursorPosition(x, 0);
                Console.WriteLine("═");
            }
            for (y = 0; y < Y; y++)
            {
                Console.SetCursorPosition((X - 1), y);
                Console.WriteLine("║");

            }
            for (x = 0; x < X; x++)
            {
                Console.SetCursorPosition(x, (Y - 1));
                Console.WriteLine("═");
            }
            Console.SetCursorPosition(0, 0); //Superior izquierda
            Console.WriteLine("╔");
            Console.SetCursorPosition(0, (Y - 1)); //Inferior izquierda
            Console.WriteLine("╚");
            Console.SetCursorPosition((X - 1), 0); //Superior derecha
            Console.WriteLine("╗");
            Console.SetCursorPosition((X - 1), (Y - 1)); //Inferior derecha
            Console.WriteLine("╝");
        }
        static void PANTALLA_AZUL()
        {
            int Y = 40;
            int X = 120;
            Console.SetWindowSize(X, Y);

            int x = 0;
            int y = 0;

            Console.ForegroundColor = ConsoleColor.Blue;
            for (y = 0; y < Y; y++)
            {
                Console.SetCursorPosition(0, y);
                Console.WriteLine("║");

            }
            for (x = 0; x < X; x++)
            {
                Console.SetCursorPosition(x, 0);
                Console.WriteLine("═");
            }
            for (y = 0; y < Y; y++)
            {
                Console.SetCursorPosition((X - 1), y);
                Console.WriteLine("║");

            }
            for (x = 0; x < X; x++)
            {
                Console.SetCursorPosition(x, (Y - 1));
                Console.WriteLine("═");
            }
            Console.SetCursorPosition(0, 0); //Superior izquierda
            Console.WriteLine("╔");
            Console.SetCursorPosition(0, (Y - 1)); //Inferior izquierda
            Console.WriteLine("╚");
            Console.SetCursorPosition((X - 1), 0); //Superior derecha
            Console.WriteLine("╗");
            Console.SetCursorPosition((X - 1), (Y - 1)); //Inferior derecha
            Console.WriteLine("╝");
        }
        static void INTERFAZ()
        {
            int Y = 40;
            int X = 120;
            Console.SetWindowSize(X, Y);

            int x = 0;
            int y = 0;


            for (y = 2; y < (Y - 1); y++)                               // CAJA DE TEXTO
            {
                Console.SetCursorPosition(3, y);
                Console.WriteLine("║");

            }
            for (x = 3; x < (X / 4); x++)
            {
                Console.SetCursorPosition(x, 1);
                Console.WriteLine("═");
            }
            Console.SetCursorPosition(3, 1); //Superior izquierda
            Console.WriteLine("╔");

            for (y = 1; y < (Y - 2); y++)                                         //CAJA DE HACKEO  
            {
                Console.SetCursorPosition(((X / 4) + 2), y);
                Console.WriteLine("║");
            }
            for (y = 1; y < (Y - 2); y++)
            {
                Console.SetCursorPosition((X - 2), y);
                Console.WriteLine("║");

            }
            for (y = 1; y < (Y - 2); y++)   // vertical interna
            {
                Console.SetCursorPosition(((X / 4) + 45), y);
                Console.WriteLine("║");

            }
            for (x = ((X / 4) + 2); x < (X - 2); x++)
            {
                Console.SetCursorPosition(x, 1);
                Console.WriteLine("═");
            }
            for (x = ((X / 4) + 2); x < (X - 2); x++)
            {
                Console.SetCursorPosition(x, (Y - 2));
                Console.WriteLine("═");
            }
            Console.SetCursorPosition(((X / 4) + 2), 1); //Superior izquierda
            Console.WriteLine("╔");
            Console.SetCursorPosition(((X / 4) + 2), (Y - 2)); //Inferior izquierda
            Console.WriteLine("╚");
            Console.SetCursorPosition((X - 2), 1); //Superior derecha
            Console.WriteLine("╗");
            Console.SetCursorPosition((X - 2), (Y - 2)); //Inferior derecha
            Console.WriteLine("╝");
            Console.SetCursorPosition(((X / 4) + 45), 1); //Corte 1
            Console.WriteLine("╦");
            Console.SetCursorPosition(((X / 4) + 45), (Y - 2)); //Corte 2
            Console.WriteLine("╩");
        }
        static void INTERFAZ_2()
        {
            int Y = 40;
            int X = 120;
            Console.SetWindowSize(X, Y);

            int x = 0;
            int y = 0;


            for (y = 2; y < (Y - 1); y++)                               // CAJA DE TEXTO
            {
                Console.SetCursorPosition(3, y);
                Console.WriteLine("║");

            }
            for (x = 3; x < (X / 4); x++)
            {
                Console.SetCursorPosition(x, 1);
                Console.WriteLine("═");
            }
            Console.SetCursorPosition(3, 1); //Superior izquierda
            Console.WriteLine("╔");

            for (y = 1; y < (Y - 2); y++)                                         //CAJA DE HACKEO  
            {
                Console.SetCursorPosition(((X / 4) + 2), y);
                Console.WriteLine("║");
            }
            for (y = 1; y < (Y - 2); y++)
            {
                Console.SetCursorPosition((X - 2), y);
                Console.WriteLine("║");

            }

            for (x = ((X / 4) + 2); x < (X - 2); x++)
            {
                Console.SetCursorPosition(x, 1);
                Console.WriteLine("═");
            }
            for (x = ((X / 4) + 2); x < (X - 2); x++)
            {
                Console.SetCursorPosition(x, (Y - 2));
                Console.WriteLine("═");
            }
            Console.SetCursorPosition(((X / 4) + 2), 1); //Superior izquierda
            Console.WriteLine("╔");
            Console.SetCursorPosition(((X / 4) + 2), (Y - 2)); //Inferior izquierda
            Console.WriteLine("╚");
            Console.SetCursorPosition((X - 2), 1); //Superior derecha
            Console.WriteLine("╗");
            Console.SetCursorPosition((X - 2), (Y - 2)); //Inferior derecha
            Console.WriteLine("╝");
            Console.SetCursorPosition(((X / 4) + 45), 1); //Corte 1
            Console.WriteLine("═");
            Console.SetCursorPosition(((X / 4) + 45), (Y - 2)); //Corte 2
            Console.WriteLine("═");
        }
        static void INTERFAZ_2_AZUL()
        {
            int Y = 40;
            int X = 120;
            Console.SetWindowSize(X, Y);

            int x = 0;
            int y = 0;

            Console.ForegroundColor = ConsoleColor.Blue;

            for (y = 2; y < (Y - 1); y++)                               // CAJA DE TEXTO
            {
                Console.SetCursorPosition(3, y);
                Console.WriteLine("║");

            }
            for (x = 3; x < (X / 4); x++)
            {
                Console.SetCursorPosition(x, 1);
                Console.WriteLine("═");
            }
            Console.SetCursorPosition(3, 1); //Superior izquierda
            Console.WriteLine("╔");

            for (y = 1; y < (Y - 2); y++)                                         //CAJA DE HACKEO  
            {
                Console.SetCursorPosition(((X / 4) + 2), y);
                Console.WriteLine("║");
            }
            for (y = 1; y < (Y - 2); y++)
            {
                Console.SetCursorPosition((X - 2), y);
                Console.WriteLine("║");

            }

            for (x = ((X / 4) + 2); x < (X - 2); x++)
            {
                Console.SetCursorPosition(x, 1);
                Console.WriteLine("═");
            }
            for (x = ((X / 4) + 2); x < (X - 2); x++)
            {
                Console.SetCursorPosition(x, (Y - 2));
                Console.WriteLine("═");
            }
            Console.SetCursorPosition(((X / 4) + 2), 1); //Superior izquierda
            Console.WriteLine("╔");
            Console.SetCursorPosition(((X / 4) + 2), (Y - 2)); //Inferior izquierda
            Console.WriteLine("╚");
            Console.SetCursorPosition((X - 2), 1); //Superior derecha
            Console.WriteLine("╗");
            Console.SetCursorPosition((X - 2), (Y - 2)); //Inferior derecha
            Console.WriteLine("╝");
            Console.SetCursorPosition(((X / 4) + 45), 1); //Corte 1
            Console.WriteLine("═");
            Console.SetCursorPosition(((X / 4) + 45), (Y - 2)); //Corte 2
            Console.WriteLine("═");
        }
        static void BIENVENIDO()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            ////////////////////////////////////////////////
            Console.SetCursorPosition(34, 2);
            Thread.Sleep(10);
            Console.WriteLine("╔╗ ╦╔═╗╔╗╔╦  ╦╔═╗╔╗╔╦╔╦╗╔═╗");
            Console.SetCursorPosition(34, 3);
            Thread.Sleep(10);
            Console.WriteLine("╠╩╗║║╣ ║║║╚╗╔╝║╣ ║║║║ ║║║ ║");
            Console.SetCursorPosition(34, 4);
            Thread.Sleep(10);
            Console.WriteLine("╚═╝╩╚═╝╝╚╝ ╚╝ ╚═╝╝╚╝╩═╩╝╚═╝");

            Console.SetCursorPosition(34, 5);
            Thread.Sleep(10);
            Console.WriteLine("╔╗ ╦╔═╗╔╗╔╦  ╦╔═╗╔╗╔╦╔╦╗╔═╗");
            Console.SetCursorPosition(34, 6);
            Thread.Sleep(10);
            Console.WriteLine("╠╩╗║║╣ ║║║╚╗╔╝║╣ ║║║║ ║║║ ║");
            Console.SetCursorPosition(34, 7);
            Thread.Sleep(10);
            Console.WriteLine("╚═╝╩╚═╝╝╚╝ ╚╝ ╚═╝╝╚╝╩═╩╝╚═╝");

            Console.SetCursorPosition(34, 8);
            Thread.Sleep(10);
            Console.WriteLine("╔╗ ╦╔═╗╔╗╔╦  ╦╔═╗╔╗╔╦╔╦╗╔═╗");
            Console.SetCursorPosition(34, 9);
            Thread.Sleep(10);
            Console.WriteLine("╠╩╗║║╣ ║║║╚╗╔╝║╣ ║║║║ ║║║ ║");
            Console.SetCursorPosition(34, 10);
            Thread.Sleep(10);
            Console.WriteLine("╚═╝╩╚═╝╝╚╝ ╚╝ ╚═╝╝╚╝╩═╩╝╚═╝");

            Console.SetCursorPosition(34, 11);
            Thread.Sleep(10);
            Console.WriteLine("╔╗ ╦╔═╗╔╗╔╦  ╦╔═╗╔╗╔╦╔╦╗╔═╗");
            Console.SetCursorPosition(34, 12);
            Thread.Sleep(10);
            Console.WriteLine("╠╩╗║║╣ ║║║╚╗╔╝║╣ ║║║║ ║║║ ║");
            Console.SetCursorPosition(34, 13);
            Thread.Sleep(10);
            Console.WriteLine("╚═╝╩╚═╝╝╚╝ ╚╝ ╚═╝╝╚╝╩═╩╝╚═╝");

            Console.SetCursorPosition(34, 14);
            Thread.Sleep(10);
            Console.WriteLine("╔╗ ╦╔═╗╔╗╔╦  ╦╔═╗╔╗╔╦╔╦╗╔═╗");
            Console.SetCursorPosition(34, 15);
            Thread.Sleep(10);
            Console.WriteLine("╠╩╗║║╣ ║║║╚╗╔╝║╣ ║║║║ ║║║ ║");
            Console.SetCursorPosition(34, 16);
            Thread.Sleep(10);
            Console.WriteLine("╚═╝╩╚═╝╝╚╝ ╚╝ ╚═╝╝╚╝╩═╩╝╚═╝");

            Console.SetCursorPosition(34, 17);
            Thread.Sleep(10);
            Console.WriteLine("╔╗ ╦╔═╗╔╗╔╦  ╦╔═╗╔╗╔╦╔╦╗╔═╗");
            Console.SetCursorPosition(34, 18);
            Thread.Sleep(10);
            Console.WriteLine("╠╩╗║║╣ ║║║╚╗╔╝║╣ ║║║║ ║║║ ║");
            Console.SetCursorPosition(34, 19);
            Thread.Sleep(10);
            Console.WriteLine("╚═╝╩╚═╝╝╚╝ ╚╝ ╚═╝╝╚╝╩═╩╝╚═╝");

            Console.SetCursorPosition(34, 20);
            Thread.Sleep(10);
            Console.WriteLine("╔╗ ╦╔═╗╔╗╔╦  ╦╔═╗╔╗╔╦╔╦╗╔═╗");
            Console.SetCursorPosition(34, 21);
            Thread.Sleep(10);
            Console.WriteLine("╠╩╗║║╣ ║║║╚╗╔╝║╣ ║║║║ ║║║ ║");
            Console.SetCursorPosition(34, 22);
            Thread.Sleep(10);
            Console.WriteLine("╚═╝╩╚═╝╝╚╝ ╚╝ ╚═╝╝╚╝╩═╩╝╚═╝");

            Console.SetCursorPosition(34, 23);
            Thread.Sleep(10);
            Console.WriteLine("╔╗ ╦╔═╗╔╗╔╦  ╦╔═╗╔╗╔╦╔╦╗╔═╗");
            Console.SetCursorPosition(34, 24);
            Thread.Sleep(10);
            Console.WriteLine("╠╩╗║║╣ ║║║╚╗╔╝║╣ ║║║║ ║║║ ║");
            Console.SetCursorPosition(34, 25);
            Thread.Sleep(10);
            Console.WriteLine("╚═╝╩╚═╝╝╚╝ ╚╝ ╚═╝╝╚╝╩═╩╝╚═╝");

            Console.SetCursorPosition(34, 26);
            Thread.Sleep(10);
            Console.WriteLine("╔╗ ╦╔═╗╔╗╔╦  ╦╔═╗╔╗╔╦╔╦╗╔═╗");
            Console.SetCursorPosition(34, 27);
            Thread.Sleep(10);
            Console.WriteLine("╠╩╗║║╣ ║║║╚╗╔╝║╣ ║║║║ ║║║ ║");
            Console.SetCursorPosition(34, 28);
            Thread.Sleep(10);
            Console.WriteLine("╚═╝╩╚═╝╝╚╝ ╚╝ ╚═╝╝╚╝╩═╩╝╚═╝");

            Console.SetCursorPosition(34, 29);
            Thread.Sleep(10);
            Console.WriteLine("╔╗ ╦╔═╗╔╗╔╦  ╦╔═╗╔╗╔╦╔╦╗╔═╗");
            Console.SetCursorPosition(34, 30);
            Thread.Sleep(10);
            Console.WriteLine("╠╩╗║║╣ ║║║╚╗╔╝║╣ ║║║║ ║║║ ║");
            Console.SetCursorPosition(34, 31);
            Thread.Sleep(10);
            Console.WriteLine("╚═╝╩╚═╝╝╚╝ ╚╝ ╚═╝╝╚╝╩═╩╝╚═╝");

            Console.SetCursorPosition(34, 32);
            Thread.Sleep(10);
            Console.WriteLine("╔╗ ╦╔═╗╔╗╔╦  ╦╔═╗╔╗╔╦╔╦╗╔═╗");
            Console.SetCursorPosition(34, 33);
            Thread.Sleep(10);
            Console.WriteLine("╠╩╗║║╣ ║║║╚╗╔╝║╣ ║║║║ ║║║ ║");
            Console.SetCursorPosition(34, 34);
            Thread.Sleep(10);
            Console.WriteLine("╚═╝╩╚═╝╝╚╝ ╚╝ ╚═╝╝╚╝╩═╩╝╚═╝");

            Console.SetCursorPosition(34, 35);
            Thread.Sleep(10);
            Console.WriteLine("╔╗ ╦╔═╗╔╗╔╦  ╦╔═╗╔╗╔╦╔╦╗╔═╗");
            Console.SetCursorPosition(34, 36);
            Thread.Sleep(10);
            Console.WriteLine("╠╩╗║║╣ ║║║╚╗╔╝║╣ ║║║║ ║║║ ║");
            Console.SetCursorPosition(34, 37);
            Thread.Sleep(10);
            Console.WriteLine("╚═╝╩╚═╝╝╚╝ ╚╝ ╚═╝╝╚╝╩═╩╝╚═╝");

            ////////////////////////////////////////////////

            Console.SetCursorPosition(62, 2);
            Thread.Sleep(10);
            Console.WriteLine("╔╗ ╦╔═╗╔╗╔╦  ╦╔═╗╔╗╔╦╔╦╗╔═╗");
            Console.SetCursorPosition(62, 3);
            Thread.Sleep(10);
            Console.WriteLine("╠╩╗║║╣ ║║║╚╗╔╝║╣ ║║║║ ║║║ ║");
            Console.SetCursorPosition(62, 4);
            Thread.Sleep(10);
            Console.WriteLine("╚═╝╩╚═╝╝╚╝ ╚╝ ╚═╝╝╚╝╩═╩╝╚═╝");

            Console.SetCursorPosition(62, 5);
            Thread.Sleep(10);
            Console.WriteLine("╔╗ ╦╔═╗╔╗╔╦  ╦╔═╗╔╗╔╦╔╦╗╔═╗");
            Console.SetCursorPosition(62, 6);
            Thread.Sleep(10);
            Console.WriteLine("╠╩╗║║╣ ║║║╚╗╔╝║╣ ║║║║ ║║║ ║");
            Console.SetCursorPosition(62, 7);
            Thread.Sleep(10);
            Console.WriteLine("╚═╝╩╚═╝╝╚╝ ╚╝ ╚═╝╝╚╝╩═╩╝╚═╝");

            Console.SetCursorPosition(62, 8);
            Thread.Sleep(10);
            Console.WriteLine("╔╗ ╦╔═╗╔╗╔╦  ╦╔═╗╔╗╔╦╔╦╗╔═╗");
            Console.SetCursorPosition(62, 9);
            Thread.Sleep(10);
            Console.WriteLine("╠╩╗║║╣ ║║║╚╗╔╝║╣ ║║║║ ║║║ ║");
            Console.SetCursorPosition(62, 10);
            Thread.Sleep(10);
            Console.WriteLine("╚═╝╩╚═╝╝╚╝ ╚╝ ╚═╝╝╚╝╩═╩╝╚═╝");

            Console.SetCursorPosition(62, 11);
            Thread.Sleep(10);
            Console.WriteLine("╔╗ ╦╔═╗╔╗╔╦  ╦╔═╗╔╗╔╦╔╦╗╔═╗");
            Console.SetCursorPosition(62, 12);
            Thread.Sleep(10);
            Console.WriteLine("╠╩╗║║╣ ║║║╚╗╔╝║╣ ║║║║ ║║║ ║");
            Console.SetCursorPosition(62, 13);
            Thread.Sleep(10);
            Console.WriteLine("╚═╝╩╚═╝╝╚╝ ╚╝ ╚═╝╝╚╝╩═╩╝╚═╝");

            Console.SetCursorPosition(62, 14);
            Thread.Sleep(10);
            Console.WriteLine("╔╗ ╦╔═╗╔╗╔╦  ╦╔═╗╔╗╔╦╔╦╗╔═╗");
            Console.SetCursorPosition(62, 15);
            Thread.Sleep(10);
            Console.WriteLine("╠╩╗║║╣ ║║║╚╗╔╝║╣ ║║║║ ║║║ ║");
            Console.SetCursorPosition(62, 16);
            Thread.Sleep(10);
            Console.WriteLine("╚═╝╩╚═╝╝╚╝ ╚╝ ╚═╝╝╚╝╩═╩╝╚═╝");

            Console.SetCursorPosition(62, 17);
            Thread.Sleep(10);
            Console.WriteLine("╔╗ ╦╔═╗╔╗╔╦  ╦╔═╗╔╗╔╦╔╦╗╔═╗");
            Console.SetCursorPosition(62, 18);
            Thread.Sleep(10);
            Console.WriteLine("╠╩╗║║╣ ║║║╚╗╔╝║╣ ║║║║ ║║║ ║");
            Console.SetCursorPosition(62, 19);
            Thread.Sleep(10);
            Console.WriteLine("╚═╝╩╚═╝╝╚╝ ╚╝ ╚═╝╝╚╝╩═╩╝╚═╝");

            Console.SetCursorPosition(62, 20);
            Thread.Sleep(10);
            Console.WriteLine("╔╗ ╦╔═╗╔╗╔╦  ╦╔═╗╔╗╔╦╔╦╗╔═╗");
            Console.SetCursorPosition(62, 21);
            Thread.Sleep(10);
            Console.WriteLine("╠╩╗║║╣ ║║║╚╗╔╝║╣ ║║║║ ║║║ ║");
            Console.SetCursorPosition(62, 22);
            Thread.Sleep(10);
            Console.WriteLine("╚═╝╩╚═╝╝╚╝ ╚╝ ╚═╝╝╚╝╩═╩╝╚═╝");

            Console.SetCursorPosition(62, 23);
            Thread.Sleep(10);
            Console.WriteLine("╔╗ ╦╔═╗╔╗╔╦  ╦╔═╗╔╗╔╦╔╦╗╔═╗");
            Console.SetCursorPosition(62, 24);
            Thread.Sleep(10);
            Console.WriteLine("╠╩╗║║╣ ║║║╚╗╔╝║╣ ║║║║ ║║║ ║");
            Console.SetCursorPosition(62, 25);
            Thread.Sleep(10);
            Console.WriteLine("╚═╝╩╚═╝╝╚╝ ╚╝ ╚═╝╝╚╝╩═╩╝╚═╝");

            Console.SetCursorPosition(62, 26);
            Thread.Sleep(10);
            Console.WriteLine("╔╗ ╦╔═╗╔╗╔╦  ╦╔═╗╔╗╔╦╔╦╗╔═╗");
            Console.SetCursorPosition(62, 27);
            Thread.Sleep(10);
            Console.WriteLine("╠╩╗║║╣ ║║║╚╗╔╝║╣ ║║║║ ║║║ ║");
            Console.SetCursorPosition(62, 28);
            Thread.Sleep(10);
            Console.WriteLine("╚═╝╩╚═╝╝╚╝ ╚╝ ╚═╝╝╚╝╩═╩╝╚═╝");

            Console.SetCursorPosition(62, 29);
            Thread.Sleep(10);
            Console.WriteLine("╔╗ ╦╔═╗╔╗╔╦  ╦╔═╗╔╗╔╦╔╦╗╔═╗");
            Console.SetCursorPosition(62, 30);
            Thread.Sleep(10);
            Console.WriteLine("╠╩╗║║╣ ║║║╚╗╔╝║╣ ║║║║ ║║║ ║");
            Console.SetCursorPosition(62, 31);
            Thread.Sleep(10);
            Console.WriteLine("╚═╝╩╚═╝╝╚╝ ╚╝ ╚═╝╝╚╝╩═╩╝╚═╝");

            Console.SetCursorPosition(62, 32);
            Thread.Sleep(10);
            Console.WriteLine("╔╗ ╦╔═╗╔╗╔╦  ╦╔═╗╔╗╔╦╔╦╗╔═╗");
            Console.SetCursorPosition(62, 33);
            Thread.Sleep(10);
            Console.WriteLine("╠╩╗║║╣ ║║║╚╗╔╝║╣ ║║║║ ║║║ ║");
            Console.SetCursorPosition(62, 34);
            Thread.Sleep(10);
            Console.WriteLine("╚═╝╩╚═╝╝╚╝ ╚╝ ╚═╝╝╚╝╩═╩╝╚═╝");

            Console.SetCursorPosition(62, 35);
            Thread.Sleep(10);
            Console.WriteLine("╔╗ ╦╔═╗╔╗╔╦  ╦╔═╗╔╗╔╦╔╦╗╔═╗");
            Console.SetCursorPosition(62, 36);
            Thread.Sleep(10);
            Console.WriteLine("╠╩╗║║╣ ║║║╚╗╔╝║╣ ║║║║ ║║║ ║");
            Console.SetCursorPosition(62, 37);
            Thread.Sleep(10);
            Console.WriteLine("╚═╝╩╚═╝╝╚╝ ╚╝ ╚═╝╝╚╝╩═╩╝╚═╝");

            ////////////////////////////////////////////////


            Console.SetCursorPosition(90, 2);
            Thread.Sleep(10);
            Console.WriteLine("╔╗ ╦╔═╗╔╗╔╦  ╦╔═╗╔╗╔╦╔╦╗╔═╗");
            Console.SetCursorPosition(90, 3);
            Thread.Sleep(10);
            Console.WriteLine("╠╩╗║║╣ ║║║╚╗╔╝║╣ ║║║║ ║║║ ║");
            Console.SetCursorPosition(90, 4);
            Thread.Sleep(10);
            Console.WriteLine("╚═╝╩╚═╝╝╚╝ ╚╝ ╚═╝╝╚╝╩═╩╝╚═╝");

            Console.SetCursorPosition(90, 5);
            Thread.Sleep(10);
            Console.WriteLine("╔╗ ╦╔═╗╔╗╔╦  ╦╔═╗╔╗╔╦╔╦╗╔═╗");
            Console.SetCursorPosition(90, 6);
            Thread.Sleep(10);
            Console.WriteLine("╠╩╗║║╣ ║║║╚╗╔╝║╣ ║║║║ ║║║ ║");
            Console.SetCursorPosition(90, 7);
            Thread.Sleep(10);
            Console.WriteLine("╚═╝╩╚═╝╝╚╝ ╚╝ ╚═╝╝╚╝╩═╩╝╚═╝");

            Console.SetCursorPosition(90, 8);
            Thread.Sleep(10);
            Console.WriteLine("╔╗ ╦╔═╗╔╗╔╦  ╦╔═╗╔╗╔╦╔╦╗╔═╗");
            Console.SetCursorPosition(90, 9);
            Thread.Sleep(10);
            Console.WriteLine("╠╩╗║║╣ ║║║╚╗╔╝║╣ ║║║║ ║║║ ║");
            Console.SetCursorPosition(90, 10);
            Thread.Sleep(10);
            Console.WriteLine("╚═╝╩╚═╝╝╚╝ ╚╝ ╚═╝╝╚╝╩═╩╝╚═╝");

            Console.SetCursorPosition(90, 11);
            Thread.Sleep(10);
            Console.WriteLine("╔╗ ╦╔═╗╔╗╔╦  ╦╔═╗╔╗╔╦╔╦╗╔═╗");
            Console.SetCursorPosition(90, 12);
            Thread.Sleep(10);
            Console.WriteLine("╠╩╗║║╣ ║║║╚╗╔╝║╣ ║║║║ ║║║ ║");
            Console.SetCursorPosition(90, 13);
            Thread.Sleep(10);
            Console.WriteLine("╚═╝╩╚═╝╝╚╝ ╚╝ ╚═╝╝╚╝╩═╩╝╚═╝");

            Console.SetCursorPosition(90, 14);
            Thread.Sleep(10);
            Console.WriteLine("╔╗ ╦╔═╗╔╗╔╦  ╦╔═╗╔╗╔╦╔╦╗╔═╗");
            Console.SetCursorPosition(90, 15);
            Thread.Sleep(10);
            Console.WriteLine("╠╩╗║║╣ ║║║╚╗╔╝║╣ ║║║║ ║║║ ║");
            Console.SetCursorPosition(90, 16);
            Thread.Sleep(10);
            Console.WriteLine("╚═╝╩╚═╝╝╚╝ ╚╝ ╚═╝╝╚╝╩═╩╝╚═╝");

            Console.SetCursorPosition(90, 17);
            Thread.Sleep(10);
            Console.WriteLine("╔╗ ╦╔═╗╔╗╔╦  ╦╔═╗╔╗╔╦╔╦╗╔═╗");
            Console.SetCursorPosition(90, 18);
            Thread.Sleep(10);
            Console.WriteLine("╠╩╗║║╣ ║║║╚╗╔╝║╣ ║║║║ ║║║ ║");
            Console.SetCursorPosition(90, 19);
            Thread.Sleep(10);
            Console.WriteLine("╚═╝╩╚═╝╝╚╝ ╚╝ ╚═╝╝╚╝╩═╩╝╚═╝");

            Console.SetCursorPosition(90, 20);
            Thread.Sleep(10);
            Console.WriteLine("╔╗ ╦╔═╗╔╗╔╦  ╦╔═╗╔╗╔╦╔╦╗╔═╗");
            Console.SetCursorPosition(90, 21);
            Thread.Sleep(10);
            Console.WriteLine("╠╩╗║║╣ ║║║╚╗╔╝║╣ ║║║║ ║║║ ║");
            Console.SetCursorPosition(90, 22);
            Thread.Sleep(10);
            Console.WriteLine("╚═╝╩╚═╝╝╚╝ ╚╝ ╚═╝╝╚╝╩═╩╝╚═╝");

            Console.SetCursorPosition(90, 23);
            Thread.Sleep(10);
            Console.WriteLine("╔╗ ╦╔═╗╔╗╔╦  ╦╔═╗╔╗╔╦╔╦╗╔═╗");
            Console.SetCursorPosition(90, 24);
            Thread.Sleep(10);
            Console.WriteLine("╠╩╗║║╣ ║║║╚╗╔╝║╣ ║║║║ ║║║ ║");
            Console.SetCursorPosition(90, 25);
            Thread.Sleep(10);
            Console.WriteLine("╚═╝╩╚═╝╝╚╝ ╚╝ ╚═╝╝╚╝╩═╩╝╚═╝");

            Console.SetCursorPosition(90, 26);
            Thread.Sleep(10);
            Console.WriteLine("╔╗ ╦╔═╗╔╗╔╦  ╦╔═╗╔╗╔╦╔╦╗╔═╗");
            Console.SetCursorPosition(90, 27);
            Thread.Sleep(10);
            Console.WriteLine("╠╩╗║║╣ ║║║╚╗╔╝║╣ ║║║║ ║║║ ║");
            Console.SetCursorPosition(90, 28);
            Thread.Sleep(10);
            Console.WriteLine("╚═╝╩╚═╝╝╚╝ ╚╝ ╚═╝╝╚╝╩═╩╝╚═╝");

            Console.SetCursorPosition(90, 29);
            Thread.Sleep(10);
            Console.WriteLine("╔╗ ╦╔═╗╔╗╔╦  ╦╔═╗╔╗╔╦╔╦╗╔═╗");
            Console.SetCursorPosition(90, 30);
            Thread.Sleep(10);
            Console.WriteLine("╠╩╗║║╣ ║║║╚╗╔╝║╣ ║║║║ ║║║ ║");
            Console.SetCursorPosition(90, 31);
            Thread.Sleep(10);
            Console.WriteLine("╚═╝╩╚═╝╝╚╝ ╚╝ ╚═╝╝╚╝╩═╩╝╚═╝");

            Console.SetCursorPosition(90, 32);
            Thread.Sleep(10);
            Console.WriteLine("╔╗ ╦╔═╗╔╗╔╦  ╦╔═╗╔╗╔╦╔╦╗╔═╗");
            Console.SetCursorPosition(90, 33);
            Thread.Sleep(10);
            Console.WriteLine("╠╩╗║║╣ ║║║╚╗╔╝║╣ ║║║║ ║║║ ║");
            Console.SetCursorPosition(90, 34);
            Thread.Sleep(10);
            Console.WriteLine("╚═╝╩╚═╝╝╚╝ ╚╝ ╚═╝╝╚╝╩═╩╝╚═╝");

            Console.SetCursorPosition(90, 35);
            Thread.Sleep(10);
            Console.WriteLine("╔╗ ╦╔═╗╔╗╔╦  ╦╔═╗╔╗╔╦╔╦╗╔═╗");
            Console.SetCursorPosition(90, 36);
            Thread.Sleep(10);
            Console.WriteLine("╠╩╗║║╣ ║║║╚╗╔╝║╣ ║║║║ ║║║ ║");
            Console.SetCursorPosition(90, 37);
            Thread.Sleep(10);
            Console.WriteLine("╚═╝╩╚═╝╝╚╝ ╚╝ ╚═╝╝╚╝╩═╩╝╚═╝");
            Console.ResetColor();

        }  //MENU
        static void FINAL_BUENO()
        {
            Console.SetCursorPosition(2, 17);
            Console.Write("███╗   ███╗██╗███████╗██╗ ██████╗ ███╗   ██╗     ██████╗██╗   ██╗███╗   ███╗██████╗ ██╗     ██╗██████╗  █████╗ ██╗");
            Console.SetCursorPosition(2, 18);
            Console.Write("████╗ ████║██║██╔════╝██║██╔═══██╗████╗  ██║    ██╔════╝██║   ██║████╗ ████║██╔══██╗██║     ██║██╔══██╗██╔══██╗██║");
            Console.SetCursorPosition(2, 19);
            Console.Write("██╔████╔██║██║███████╗██║██║   ██║██╔██╗ ██║    ██║     ██║   ██║██╔████╔██║██████╔╝██║     ██║██║  ██║███████║██║");
            Console.SetCursorPosition(2, 20);
            Console.Write("██║╚██╔╝██║██║╚════██║██║██║   ██║██║╚██╗██║    ██║     ██║   ██║██║╚██╔╝██║██╔═══╝ ██║     ██║██║  ██║██╔══██║╚═╝");
            Console.SetCursorPosition(2, 21);
            Console.Write("██║ ╚═╝ ██║██║███████║██║╚██████╔╝██║ ╚████║    ╚██████╗╚██████╔╝██║ ╚═╝ ██║██║     ███████╗██║██████╔╝██║  ██║██╗");
            Console.SetCursorPosition(2, 22);
            Console.Write("╚═╝     ╚═╝╚═╝╚══════╝╚═╝ ╚═════╝ ╚═╝  ╚═══╝     ╚═════╝ ╚═════╝ ╚═╝     ╚═╝╚═╝     ╚══════╝╚═╝╚═════╝ ╚═╝  ╚═╝╚═╝");
        }
        static void FINAL_MALO()
        {
            Console.SetCursorPosition(4, 17);
            Console.Write("███╗   ███╗██╗███████╗██╗ ██████╗ ███╗   ██╗    ███████╗ █████╗ ██╗     ██╗     ██╗██████╗  █████╗         ██╗");
            Console.SetCursorPosition(4, 18);
            Console.Write("████╗ ████║██║██╔════╝██║██╔═══██╗████╗  ██║    ██╔════╝██╔══██╗██║     ██║     ██║██╔══██╗██╔══██╗    ██╗██╔╝");
            Console.SetCursorPosition(4, 19);
            Console.Write("██╔████╔██║██║███████╗██║██║   ██║██╔██╗ ██║    █████╗  ███████║██║     ██║     ██║██║  ██║███████║    ╚═╝██║ ");
            Console.SetCursorPosition(4, 20);
            Console.Write("██║╚██╔╝██║██║╚════██║██║██║   ██║██║╚██╗██║    ██╔══╝  ██╔══██║██║     ██║     ██║██║  ██║██╔══██║    ██╗██║ ");
            Console.SetCursorPosition(4, 21);
            Console.Write("██║ ╚═╝ ██║██║███████║██║╚██████╔╝██║ ╚████║    ██║     ██║  ██║███████╗███████╗██║██████╔╝██║  ██║    ╚═╝╚██╗");
            Console.SetCursorPosition(4, 22);
            Console.Write("╚═╝     ╚═╝╚═╝╚══════╝╚═╝ ╚═════╝ ╚═╝  ╚═══╝    ╚═╝     ╚═╝  ╚═╝╚══════╝╚══════╝╚═╝╚═════╝ ╚═╝  ╚═╝        ╚═╝");
        }

        static void SIGNOS_ALEATORIOS()
        {
            int Y = 40;
            int X = 120;
            int y = 0;

            Random SIGN = new Random();
            string variable = "!\"#$%&'()*+,-./:;<=>?@]^_`{|}~\\";
            int longitud = variable.Length;
            char L;
            for (int i = 2; i < (Y - 2); i++)
            {
                Console.SetCursorPosition(((X / 4) + 3), i);
                for (int q = 33; q < 118; q++)
                {
                    L = variable[SIGN.Next(longitud)];
                    Console.Write(L);
                }
            }
            for (y = 2; y < (Y - 2); y++)   // vertical interna
            {
                Console.SetCursorPosition(((X / 4) + 45), y);
                Console.WriteLine("║");
            }
        }              //HACKEO
        static void PALABRAS_ALEATORIAS()
        {
            int X = 120;
            int x = ((X / 4) + 3);
            int f = 47;

            var G1 = new[] { "CASA", "PERA", "COMA", "TELA", "PIÑA", "TOMA", "LUNA", "COSA", "TINA", "PAPA" };
            var G2 = new[] { "DUDA", "CITA", "HIJO", "ESTO", "EURO", "DIVA", "CUBA", "FLOR", "GOCE", "LUPA" };
            var G3 = new[] { "ATUN", "LATA", "SOPA", "TEMA", "CITA", "GATO", "DIOS", "RANA", "MOLE", "PASA" };
            var G4 = new[] { "PUMA", "POMO", "COLA", "TERA", "TINO", "FINO", "GULA", "YATE", "MESA", "ROMA" };
            var G5 = new[] { "CERO", "PESO", "PASO", "TAZA", "HORA", "RAYO", "LAZO", "PEDO", "TIRA", "PESA" };
            var words1Random = G1.OrderBy(i => Guid.NewGuid());
            var words2Random = G2.OrderBy(i => Guid.NewGuid());
            var words3Random = G3.OrderBy(i => Guid.NewGuid());
            var words4Random = G4.OrderBy(i => Guid.NewGuid());
            var words5Random = G5.OrderBy(i => Guid.NewGuid());
            ArrayList G1_OR = new ArrayList();
            Random VALOR = new Random();
            int V = VALOR.Next(1, 5);
            int u = 0;
            switch (V)
            {
                case 1:
                    foreach (var word in words1Random)
                    {
                        G1_OR.Insert(u, word);
                        u = u + 1;
                    }
                    break;
                case 2:
                    foreach (var word in words2Random)
                    {
                        G1_OR.Insert(u, word);
                        u = u + 1;
                    }
                    break;
                case 3:
                    foreach (var word in words3Random)
                    {
                        G1_OR.Insert(u, word);
                        u = u + 1;
                    }
                    break;
                case 4:
                    foreach (var word in words4Random)
                    {
                        G1_OR.Insert(u, word);
                        u = u + 1;
                    }
                    break;
                case 5:
                    foreach (var word in words5Random)
                    {
                        G1_OR.Insert(u, word);
                        u = u + 1;
                    }
                    break;
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Random POSITION = new Random();
            for (int i = 0; i <= 10; i = i + 2)
            {
                POSITION.Next(200);
                int W;
                int H;
                switch (i)
                {
                    case 0:
                        W = POSITION.Next(33, 68);
                        H = POSITION.Next(1, 7);
                        Console.SetCursorPosition((W), (2 + H));
                        Console.WriteLine(G1_OR[i]);
                        W = POSITION.Next(33, 68) + (f);
                        H = POSITION.Next(1, 7);
                        Console.SetCursorPosition(W, (2 + H));
                        Console.WriteLine(G1_OR[i + 1]);
                        break;
                    case 2:
                        W = POSITION.Next(33, 68);
                        H = POSITION.Next(1, 7);
                        Console.SetCursorPosition(W, (9 + H));
                        Console.WriteLine(G1_OR[i]);
                        W = POSITION.Next(33, 68) + (f);
                        H = POSITION.Next(1, 7);
                        Console.SetCursorPosition(W, (9 + H));
                        Console.WriteLine(G1_OR[i + 1]);
                        break;
                    case 4:
                        W = POSITION.Next(33, 68);
                        H = POSITION.Next(1, 7);
                        Console.SetCursorPosition(W, (16 + H));
                        Console.WriteLine(G1_OR[i]);
                        W = POSITION.Next(33, 68) + (f);
                        H = POSITION.Next(1, 7);
                        Console.SetCursorPosition(W, (16 + H));
                        Console.WriteLine(G1_OR[i + 1]);
                        break;
                    case 6:
                        W = POSITION.Next(33, 68);
                        H = POSITION.Next(1, 7);
                        Console.SetCursorPosition(W, (23 + H));
                        Console.WriteLine(G1_OR[i]);
                        W = POSITION.Next(33, 68) + (f);
                        H = POSITION.Next(1, 7);
                        Console.SetCursorPosition(W, (23 + H));
                        Console.WriteLine(G1_OR[i + 1]);
                        break;
                    case 8:
                        W = POSITION.Next(33, 68);
                        H = POSITION.Next(1, 7);
                        Console.SetCursorPosition(W, (30 + H));
                        Console.WriteLine(G1_OR[i]);
                        W = POSITION.Next(33, 68) + (f);
                        H = POSITION.Next(1, 7);
                        Console.SetCursorPosition(W, (30 + H));
                        Console.WriteLine(G1_OR[i + 1]);
                        break;
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Random ASIGNAR = new Random();                            // LECTURA DE LA PALABRA "RESPUESTA" Y CONVERSIÓN A CHAR
            int R = ASIGNAR.Next(1, 10);
            string CORRECTO = Convert.ToString(G1_OR[R]);
            ArrayList CHAR1 = new ArrayList();
            for (int z = 0; z < CORRECTO.Length; z++)
            {
                CHAR1.Insert(z, CORRECTO.Substring(z, 1));
            }

            String A = "Elija una palabra que coin-";                        ///// INICIO DEL JUEGO
            String B = "cida con la contraseña. La ";
            String C = "posición del carácter indi-";
            String D = "ca el  número de  aciertos ";
            string E = "de  la contraseña.";



            int avance = 0;
            int ERRORES = 4;
            int AcumAnswer = 0;


            Console.SetCursorPosition(4, (2 + avance));
            Console.WriteLine("{0}", A);
            avance = avance + 1;
            Console.SetCursorPosition(4, (2 + avance));
            Console.WriteLine("{0}", B);
            avance = avance + 1;
            Console.SetCursorPosition(4, (2 + avance));
            Console.WriteLine("{0}", C);
            avance = avance + 1;
            Console.SetCursorPosition(4, (2 + avance));
            Console.WriteLine("{0}", D);
            avance = avance + 1;
            Console.SetCursorPosition(4, (2 + avance));
            Console.WriteLine("{0}", E);
            avance = avance + 2;

            for (int REPETICION = 0; REPETICION < 4; REPETICION++)
            {
                INICIO1:
                Console.SetCursorPosition(4, (2 + avance));
                Console.WriteLine("Inserte una contraseña>>>>>");
                avance = avance + 1;
                Console.SetCursorPosition(4, (2 + avance));
                Console.ForegroundColor = ConsoleColor.Red;
                string RESPUESTA = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                avance = avance + 1;
                ArrayList CHAR2 = new ArrayList();
                AcumAnswer = 0;

                for (int z = 0; z < RESPUESTA.Length; z++)
                {
                    CHAR2.Insert(z, RESPUESTA.Substring(z, 1));
                }


                for (int Val = 0; Val < RESPUESTA.Length; Val++)            // COMPARACIÓN DE RESPUESTAS
                {
                    Char AA = Convert.ToChar(CHAR1[Val]);
                    Char BB = Convert.ToChar(CHAR2[Val]);

                    if (AA == BB)
                    {
                        AcumAnswer = AcumAnswer + 1;
                    }
                }

                int ACUM = AcumAnswer;

                if (ACUM == 4)
                {
                    Console.SetCursorPosition(4, (2 + avance));
                    Console.WriteLine("<CONTRASEÑA ENCONTRADA>");
                    avance = avance + 1;
                    REPETICION = 5;
                }
                else
                {
                    ERRORES = ERRORES - 1;
                    int GG = ERRORES;
                    if (GG <= 0)
                    {
                        Console.SetCursorPosition(4, (2 + avance));
                        Console.WriteLine("Contraseña incorrecta...");
                        avance = avance + 1;
                        Console.SetCursorPosition(4, (2 + avance));
                        Console.WriteLine("la palabra coincide en {0}/{1}", ACUM, RESPUESTA.Length);
                        avance = avance + 1;
                        Console.SetCursorPosition(4, (2 + avance));
                        Console.WriteLine("posiciones...");
                        avance = avance + 1;
                        Console.SetCursorPosition(4, (2 + avance));
                        Console.WriteLine("Quedan {0} intentos.", ERRORES);
                        avance = avance + 1;
                        Console.SetCursorPosition(4, (2 + avance));
                        Console.Write("ERROR... PC BLOQUEADA");
                        Thread.Sleep(600);
                        Console.Write(".");
                        Thread.Sleep(600);
                        Console.Write(".");
                        Thread.Sleep(600);
                        Console.Write(".");
                        Thread.Sleep(600);
                        Console.Write(".");
                        Thread.Sleep(600);
                        Console.Write(".");
                        Thread.Sleep(600);
                        Console.Write(".");
                        Thread.Sleep(600);
                        Console.Write(".");
                        avance = avance + 1;
                        Thread.Sleep(1400);

                        Console.SetCursorPosition(4, (2 + avance));
                        Console.WriteLine("ALARMA ACTIVADA");
                        avance = avance + 1;
                        Thread.Sleep(1400);
                        Console.SetCursorPosition(4, (2 + avance));
                        Console.WriteLine("DESACTIVA LA ALARMA");
                        avance = avance + 1;
                        REPETICION = 5;
                        JUEGO_4();
                    }
                    else
                    {
                        Console.SetCursorPosition(4, (2 + avance));
                        Console.WriteLine("Contraseña incorrecta...");
                        avance = avance + 1;
                        Console.SetCursorPosition(4, (2 + avance));
                        Console.WriteLine("la palabra coincide en {0}/{1}", ACUM, RESPUESTA.Length);
                        avance = avance + 1;
                        Console.SetCursorPosition(4, (2 + avance));
                        Console.WriteLine("posiciones...");
                        avance = avance + 1;
                        Console.SetCursorPosition(4, (2 + avance));
                        Console.WriteLine("Quedan {0} intentos.", ERRORES);
                        avance = avance + 1;
                        goto INICIO1;
                    }
                }
            }
            Thread.Sleep(6000);

        }            //HACKEO
        static void PALABRAS_ALEATORIAS_DIFICIL()
        {
            int X = 120;
            int x = ((X / 4) + 3);
            int f = 47;

            var G1 = new[] { "ABURRICION", "ACEPTACION", "AFILIACION", "ATENUACION", "CACHIVACHE", "CALCOMANIA", "CALIGRAFIA", "CALORIFICA", "CAPITALINO", "ABOLLADURA" }; //CION
            var G2 = new[] { "CALCINADOR", "CALCULABLE", "CALCINABLE", "CALVINISMO", "CAMPAMENTO", "CAMPANARIO", "CAMPANILLA", "CAMPECHANO", "CARPINTERO", "CENICIENTA" };  //EMPIEZA EN C
            var G3 = new[] { "AFICIONADO", "VALIDACION", "VACUNACION", "ROTULACION", "EXHIBICION", "DIFAMACION", "DECREMENTO", "CAMPANILLA", "CAMPECHANO", "CACHIVACHE" }; //CION
            var G4 = new[] { "AFICIONADO", "AFORTUNADO", "ADELANTADO", "ADHERENCIA", "AGRUPACION", "ASFIXIANTE", "ATROPELLAR", "ATORMENTAR", "ATOMIZADOR", "ASALARIADO" }; //CON A
            var G5 = new[] { "FISIOLOGIA", "PSICOLOGIA", "ETIMOLOGIA", "GENEALOGIA", "ABRAZADERA", "BANCARROTA", "DECREMENTO", "DECORATIVO", "REAPARECER", "REBAUTIZAR" }; //LOGIA
            var words1Random = G1.OrderBy(i => Guid.NewGuid());
            var words2Random = G2.OrderBy(i => Guid.NewGuid());
            var words3Random = G3.OrderBy(i => Guid.NewGuid());
            var words4Random = G4.OrderBy(i => Guid.NewGuid());
            var words5Random = G5.OrderBy(i => Guid.NewGuid());
            ArrayList G1_OR = new ArrayList();
            Random VALOR = new Random();
            int V = VALOR.Next(1, 5);
            int u = 0;
            switch (V)
            {
                case 1:
                    foreach (var word in words1Random)
                    {
                        G1_OR.Insert(u, word);
                        u = u + 1;
                    }
                    break;
                case 2:
                    foreach (var word in words2Random)
                    {
                        G1_OR.Insert(u, word);
                        u = u + 1;
                    }
                    break;
                case 3:
                    foreach (var word in words3Random)
                    {
                        G1_OR.Insert(u, word);
                        u = u + 1;
                    }
                    break;
                case 4:
                    foreach (var word in words4Random)
                    {
                        G1_OR.Insert(u, word);
                        u = u + 1;
                    }
                    break;
                case 5:
                    foreach (var word in words5Random)
                    {
                        G1_OR.Insert(u, word);
                        u = u + 1;
                    }
                    break;
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Random POSITION = new Random();
            for (int i = 0; i <= 10; i = i + 2)
            {
                POSITION.Next(200);
                int W;
                int H;
                switch (i)
                {
                    case 0:
                        W = POSITION.Next(33, 62);
                        H = POSITION.Next(1, 7);
                        Console.SetCursorPosition((W), (2 + H));
                        Console.WriteLine(G1_OR[i]);
                        W = POSITION.Next(33, 62) + (f);
                        H = POSITION.Next(1, 7);
                        Console.SetCursorPosition(W, (2 + H));
                        Console.WriteLine(G1_OR[i + 1]);
                        break;
                    case 2:
                        W = POSITION.Next(33, 62);
                        H = POSITION.Next(1, 7);
                        Console.SetCursorPosition(W, (9 + H));
                        Console.WriteLine(G1_OR[i]);
                        W = POSITION.Next(33, 62) + (f);
                        H = POSITION.Next(1, 7);
                        Console.SetCursorPosition(W, (9 + H));
                        Console.WriteLine(G1_OR[i + 1]);
                        break;
                    case 4:
                        W = POSITION.Next(33, 62);
                        H = POSITION.Next(1, 7);
                        Console.SetCursorPosition(W, (16 + H));
                        Console.WriteLine(G1_OR[i]);
                        W = POSITION.Next(33, 62) + (f);
                        H = POSITION.Next(1, 7);
                        Console.SetCursorPosition(W, (16 + H));
                        Console.WriteLine(G1_OR[i + 1]);
                        break;
                    case 6:
                        W = POSITION.Next(33, 62);
                        H = POSITION.Next(1, 7);
                        Console.SetCursorPosition(W, (23 + H));
                        Console.WriteLine(G1_OR[i]);
                        W = POSITION.Next(33, 62) + (f);
                        H = POSITION.Next(1, 7);
                        Console.SetCursorPosition(W, (23 + H));
                        Console.WriteLine(G1_OR[i + 1]);
                        break;
                    case 8:
                        W = POSITION.Next(33, 62);
                        H = POSITION.Next(1, 7);
                        Console.SetCursorPosition(W, (30 + H));
                        Console.WriteLine(G1_OR[i]);
                        W = POSITION.Next(33, 62) + (f);
                        H = POSITION.Next(1, 7);
                        Console.SetCursorPosition(W, (30 + H));
                        Console.WriteLine(G1_OR[i + 1]);
                        break;
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Random ASIGNAR = new Random();                            // LECTURA DE LA PALABRA "RESPUESTA" Y CONVERSIÓN A CHAR
            int R = ASIGNAR.Next(1, 10);
            string CORRECTO = Convert.ToString(G1_OR[R]);
            ArrayList CHAR1 = new ArrayList();
            for (int z = 0; z < CORRECTO.Length; z++)
            {
                CHAR1.Insert(z, CORRECTO.Substring(z, 1));
            }

            String A = "Elija una palabra que coin-";                        ///// INICIO DEL JUEGO
            String B = "cida con la contraseña. La ";
            String C = "posición del carácter indi-";
            String D = "ca el  número de  aciertos ";
            string E = "de  la contraseña.";



            int avance = 0;
            int ERRORES = 4;
            int AcumAnswer = 0;


            Console.SetCursorPosition(4, (2 + avance));
            Console.WriteLine("{0}", A);
            avance = avance + 1;
            Console.SetCursorPosition(4, (2 + avance));
            Console.WriteLine("{0}", B);
            avance = avance + 1;
            Console.SetCursorPosition(4, (2 + avance));
            Console.WriteLine("{0}", C);
            avance = avance + 1;
            Console.SetCursorPosition(4, (2 + avance));
            Console.WriteLine("{0}", D);
            avance = avance + 1;
            Console.SetCursorPosition(4, (2 + avance));
            Console.WriteLine("{0}", E);
            avance = avance + 2;

            for (int REPETICION = 0; REPETICION < 4; REPETICION++)
            {
                INICIO1:
                Console.SetCursorPosition(4, (2 + avance));
                Console.WriteLine("Inserte una contraseña>>>>>");
                avance = avance + 1;
                Console.SetCursorPosition(4, (2 + avance));
                Console.ForegroundColor = ConsoleColor.Red;
                string RESPUESTA = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                avance = avance + 1;
                ArrayList CHAR2 = new ArrayList();
                AcumAnswer = 0;

                for (int z = 0; z < RESPUESTA.Length; z++)
                {
                    CHAR2.Insert(z, RESPUESTA.Substring(z, 1));
                }


                for (int Val = 0; Val < RESPUESTA.Length; Val++)            // COMPARACIÓN DE RESPUESTAS
                {
                    Char AA = Convert.ToChar(CHAR1[Val]);
                    Char BB = Convert.ToChar(CHAR2[Val]);

                    if (AA == BB)
                    {
                        AcumAnswer = AcumAnswer + 1;
                    }
                }

                int ACUM = AcumAnswer;

                if (ACUM == 10)
                {
                    Console.SetCursorPosition(4, (2 + avance));
                    Console.WriteLine("<CONTRASEÑA ENCONTRADA>");
                    avance = avance + 1;
                    REPETICION = 5;
                }
                else
                {
                    ERRORES = ERRORES - 1;
                    int GG = ERRORES;
                    if (GG <= 0)
                    {
                        Console.SetCursorPosition(4, (2 + avance));
                        Console.WriteLine("Contraseña incorrecta...");
                        avance = avance + 1;
                        Console.SetCursorPosition(4, (2 + avance));
                        Console.WriteLine("la palabra coincide en {0}/{1}", ACUM, RESPUESTA.Length);
                        avance = avance + 1;
                        Console.SetCursorPosition(4, (2 + avance));
                        Console.WriteLine("posiciones...");
                        avance = avance + 1;
                        Console.SetCursorPosition(4, (2 + avance));
                        Console.WriteLine("Quedan {0} intentos.", ERRORES);
                        avance = avance + 1;
                        Console.SetCursorPosition(4, (2 + avance));
                        Console.Write("ERROR... PC BLOQUEADA");
                        Thread.Sleep(600);
                        Console.Write(".");
                        Thread.Sleep(600);
                        Console.Write(".");
                        Thread.Sleep(600);
                        Console.Write(".");
                        Thread.Sleep(600);
                        Console.Write(".");
                        Thread.Sleep(600);
                        Console.Write(".");
                        Thread.Sleep(600);
                        Console.Write(".");
                        Thread.Sleep(600);
                        Console.Write(".");
                        avance = avance + 1;
                        Thread.Sleep(1400);

                        Console.SetCursorPosition(4, (2 + avance));
                        Console.WriteLine("ALARMA ACTIVADA");
                        avance = avance + 1;
                        Thread.Sleep(1400);
                        Console.SetCursorPosition(4, (2 + avance));
                        Console.WriteLine("DESACTIVA LA ALARMA");
                        avance = avance + 1;
                        REPETICION = 5;
                        JUEGO_4();
                    }
                    else
                    {
                        Console.SetCursorPosition(4, (2 + avance));
                        Console.WriteLine("Contraseña incorrecta...");
                        avance = avance + 1;
                        Console.SetCursorPosition(4, (2 + avance));
                        Console.WriteLine("la palabra coincide en {0}/{1}", ACUM, RESPUESTA.Length);
                        avance = avance + 1;
                        Console.SetCursorPosition(4, (2 + avance));
                        Console.WriteLine("posiciones...");
                        avance = avance + 1;
                        Console.SetCursorPosition(4, (2 + avance));
                        Console.WriteLine("Quedan {0} intentos.", ERRORES);
                        avance = avance + 1;
                        goto INICIO1;
                    }
                }
            }
            Thread.Sleep(6000);

        }    //HACKEO
        static void CERROJO()
        {
            int Y = 19;   // punto central
            int X = 78;  // punto central
            Console.ForegroundColor = ConsoleColor.DarkGray;    //  ╔══╗█
            Console.SetCursorPosition((X - 4), (Y - 2));
            Console.Write("  ╔═══╗  ");
            Console.SetCursorPosition((X - 4), (Y - 1));
            Console.Write("╔═╝▐█▌╚═╗");
            Console.SetCursorPosition((X - 4), Y);
            Console.Write("║▐█████▌║");
            Console.SetCursorPosition((X - 4), (Y + 1));
            Console.Write("║▐█████▌║");
            Console.SetCursorPosition((X - 4), (Y + 2));
            Console.Write("╚═══════╝");
            Console.ResetColor();
        }                                       //LOCKPICK
        static void MARCO_DE_INTERFAZ()
        {
            int x = 0;
            int y = 0;

            Console.ForegroundColor = ConsoleColor.DarkYellow;

            for (y = 2; y < 38; y++)
            {
                Console.SetCursorPosition(37, y);
                Console.WriteLine("║");
            }
            for (y = 2; y < 38; y++)
            {
                Console.SetCursorPosition(2, y);
                Console.WriteLine("║");
            }
            for (x = 2; x < 38; x++)
            {
                Console.SetCursorPosition(x, 1);
                Console.WriteLine("═");
            }
            for (x = 2; x < 38; x++)
            {
                Console.SetCursorPosition(x, 38);
                Console.WriteLine("═");
            }
            Console.SetCursorPosition(2, 1); //Superior izquierda
            Console.WriteLine("╔");
            Console.SetCursorPosition(2, 38); //Inferior izquierda
            Console.WriteLine("╚");
            Console.SetCursorPosition(37, 1); //Superior derecha
            Console.WriteLine("╗");
            Console.SetCursorPosition(37, 38); //Inferior derecha
            Console.WriteLine("╝");

            Console.SetCursorPosition(3, 2);
            Console.Write("Mueve la Ganzúa y presiona enter ");                          //LENGTH MAX = 33
            Console.SetCursorPosition(3, 3);
            Console.Write(" para liberar el cerrojo. ");

            Console.SetCursorPosition(12, 5);                                            //INSTRUCCIONES
            Console.Write("CONTROLES");
            Console.SetCursorPosition(3, 6);
            Console.Write("LEFT ARROW = mover izquierda");
            Console.SetCursorPosition(3, 7);
            Console.Write("RIGHT ARROW = mover derecha");
            Console.SetCursorPosition(3, 8);
            Console.Write("ENTER = forzar cerrojo");
            Console.ResetColor();
        }                             //LOCKPICK
        static void LINEA_DERECHA()
        {
            int Y = 19;   // punto central
            int X = 78;  // punto central
            for (int a = 3; a < 20; a++)                        //LINEA DERECHA
            {
                Console.SetCursorPosition((X + (a * 2)), Y);
                Console.Write("■");
            }
        }                                 //LOCKPICK
        static void LINEA_IZQUIERDA()
        {
            int Y = 19;   // punto central
            int X = 78;  // punto central
            for (int a = 3; a < 20; a++)                        //LINEA IZQUIERDA
            {
                Console.SetCursorPosition((X - (a * 2)), Y);
                Console.Write("■");
            }
        }                               //LOCKPICK
        static void LINEA_INFERIOR()
        {
            int Y = 19;   // punto central
            int X = 78;  // punto central
            for (int a = 3; a < 18; a++)                        //LINEA INFERIOR
            {
                Console.SetCursorPosition(X, (Y + a));
                Console.Write("■");
            }
        }                                //LOCKPICK
        static void LINEA_SUPERIOR()
        {
            int Y = 19;   // punto central
            int X = 78;  // punto central
            for (int a = 3; a < 18; a++)                        //LINEA SUPERIOR
            {
                Console.SetCursorPosition(X, (Y - a));
                Console.Write("■");
            }
        }                                //LOCKPICK
        static void LINEA_DIAGONAL_INFERIOR_DERECHA()
        {
            int Y = 19;   // punto central
            int X = 78;  // punto central
            for (int a = 3; a < 15; a++)                        //LINEA DIAGONAL INFERIOR DERECHA
            {
                Console.SetCursorPosition((X + (a * 2)), (Y + a));
                Console.Write("■");
            }
        }               //LOCKPICK
        static void LINEA_DIAGONAL_INFERIOR_IZQUIERDA()
        {
            int Y = 19;   // punto central
            int X = 78;  // punto central
            for (int a = 3; a < 15; a++)                        // LINEA DIAGONAL INFERIOR IZQUIERDA   
            {
                Console.SetCursorPosition((X - (a * 2)), (Y + a));
                Console.Write("■");
            }
        }             //LOCKPICK
        static void LINEA_DIAGONAL_SUPERIOR_DERECHA()
        {
            int Y = 19;   // punto central
            int X = 78;  // punto central
            for (int a = 2; a < 15; a++)                        //LINEA DIAGONAL SUPERIOR DERECHA
            {
                Console.SetCursorPosition((X + (a * 2)), (Y - a));
                Console.Write("■");
            }
        }               //LOCKPICK
        static void LINEA_DIAGONAL_SUPERIOR_IZQUIERDA()
        {
            int Y = 19;   // punto central
            int X = 78;  // punto central
            for (int a = 2; a < 15; a++)                        // LINEA DIAGONAL SUPERIOR IZQUIERDA
            {
                Console.SetCursorPosition((X - (a * 2)), (Y - a));
                Console.Write("■");
            }
        }             //LOCKPICK
        static void BORRAR_LINEA_DERECHA()
        {
            int Y = 19;   // punto central
            int X = 78;  // punto central
            for (int a = 3; a < 20; a++)                        //LINEA DERECHA
            {
                Console.SetCursorPosition((X + (a * 2)), Y);
                Console.Write(" ");
            }
        }                          //LOCKPICK
        static void BORRAR_LINEA_IZQUIERDA()
        {
            int Y = 19;   // punto central
            int X = 78;  // punto central
            for (int a = 3; a < 20; a++)                        //LINEA IZQUIERDA
            {
                Console.SetCursorPosition((X - (a * 2)), Y);
                Console.Write(" ");
            }
        }                        //LOCKPICK
        static void BORRAR_LINEA_INFERIOR()
        {
            int Y = 19;   // punto central
            int X = 78;  // punto central
            for (int a = 3; a < 18; a++)                        //LINEA INFERIOR
            {
                Console.SetCursorPosition(X, (Y + a));
                Console.Write(" ");
            }
        }                         //LOCKPICK
        static void BORRAR_LINEA_SUPERIOR()
        {
            int Y = 19;   // punto central
            int X = 78;  // punto central
            for (int a = 3; a < 18; a++)                        //LINEA SUPERIOR
            {
                Console.SetCursorPosition(X, (Y - a));
                Console.Write(" ");
            }
        }                         //LOCKPICK
        static void BORRAR_LINEA_DIAGONAL_INFERIOR_DERECHA()
        {
            int Y = 19;   // punto central
            int X = 78;  // punto central
            for (int a = 3; a < 15; a++)                        //LINEA DIAGONAL INFERIOR DERECHA
            {
                Console.SetCursorPosition((X + (a * 2)), (Y + a));
                Console.Write(" ");
            }
        }        //LOCKPICK
        static void BORRAR_LINEA_DIAGONAL_INFERIOR_IZQUIERDA()
        {
            int Y = 19;   // punto central
            int X = 78;  // punto central
            for (int a = 3; a < 15; a++)                        // LINEA DIAGONAL INFERIOR IZQUIERDA   
            {
                Console.SetCursorPosition((X - (a * 2)), (Y + a));
                Console.Write(" ");
            }
        }      //LOCKPICK
        static void BORRAR_LINEA_DIAGONAL_SUPERIOR_DERECHA()
        {
            int Y = 19;   // punto central
            int X = 78;  // punto central
            for (int a = 2; a < 15; a++)                        //LINEA DIAGONAL SUPERIOR DERECHA
            {
                Console.SetCursorPosition((X + (a * 2)), (Y - a));
                Console.Write(" ");
            }
        }        //LOCKPICK
        static void BORRAR_LINEA_DIAGONAL_SUPERIOR_IZQUIERDA()
        {
            int Y = 19;   // punto central
            int X = 78;  // punto central
            for (int a = 2; a < 15; a++)                        // LINEA DIAGONAL SUPERIOR IZQUIERDA
            {
                Console.SetCursorPosition((X - (a * 2)), (Y - a));
                Console.Write(" ");
            }
        }      //LOCKPICK
        static void MEDIDOR()
        {
            int x = 0;
            int y = 0;

            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.SetCursorPosition(6, 33);
            Console.Write("MEDIDOR DE FORZADO"); //LENGTH = 18

            for (y = 34; y < 38; y++)
            {
                Console.SetCursorPosition(35, y);
                Console.WriteLine("║");
            }
            for (y = 34; y < 38; y++)
            {
                Console.SetCursorPosition(4, y);
                Console.WriteLine("║");
            }
            for (y = 34; y < 38; y++)
            {
                Console.SetCursorPosition(29, y);
                Console.WriteLine("║");
            }
            for (x = 4; x < 35; x++)
            {
                Console.SetCursorPosition(x, 34);
                Console.WriteLine("═");
            }
            Console.SetCursorPosition(4, 38);
            Console.WriteLine("╩");
            Console.SetCursorPosition(35, 38);
            Console.WriteLine("╩");
            Console.SetCursorPosition(29, 38);
            Console.WriteLine("╩");
            Console.SetCursorPosition(29, 34);
            Console.WriteLine("╦");
            Console.SetCursorPosition(4, 34);
            Console.WriteLine("╔");
            Console.SetCursorPosition(35, 34);
            Console.WriteLine("╗");
            Console.ResetColor();
        }                                       //LOCKPICK
        static void BARRA_MEDIDOR()
        {
            Console.SetCursorPosition(31, 35);
            Console.WriteLine("█");
            Console.SetCursorPosition(32, 35);
            Console.WriteLine("█");
            Console.SetCursorPosition(33, 35);
            Console.WriteLine("█");
            Console.SetCursorPosition(34, 35);
            Console.WriteLine("█");
            Console.SetCursorPosition(31, 36);
            Console.WriteLine("█");
            Console.SetCursorPosition(32, 36);
            Console.WriteLine("█");
            Console.SetCursorPosition(33, 36);
            Console.WriteLine("█");
            Console.SetCursorPosition(34, 36);
            Console.WriteLine("█");
            Console.SetCursorPosition(31, 37);
            Console.WriteLine("█");
            Console.SetCursorPosition(32, 37);
            Console.WriteLine("█");
            Console.SetCursorPosition(33, 37);
            Console.WriteLine("█");
            Console.SetCursorPosition(34, 37);
            Console.WriteLine("█");
        }                                 //LOCKPICK
        static void BARRA_VERDE()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            BARRA_MEDIDOR();
            Console.SetCursorPosition(5, 36);
            Console.Write("                    ");
            Console.SetCursorPosition(6, 36);
            Console.Write("!LO LOGRASTE!"); //13
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
        }                                   //LOCKPICK
        static void BARRA_VERDE_OSCURO()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            BARRA_MEDIDOR();
            Console.SetCursorPosition(5, 36);
            Console.Write("                    ");
            Console.SetCursorPosition(7, 36);
            Console.Write("¡MUY CERCA!"); //11
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
        }                            //LOCKPICK
        static void BARRA_AMARILLA()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            BARRA_MEDIDOR();
            Console.SetCursorPosition(5, 36);
            Console.Write("                    ");
            Console.SetCursorPosition(7, 36);
            Console.Write("Estás algo cerca."); //17
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
        }                                //LOCKPICK
        static void BARRA_ROJA()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            BARRA_MEDIDOR();
            Console.SetCursorPosition(5, 36);
            Console.Write("                    ");
            Console.SetCursorPosition(11, 36);
            Console.Write("MAL."); //4
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
        }                                    //LOCKPICK
        static void GAME_LOOP()
        {
            int A = 0;
            int B = 3;
            int POSITION = 0;
            Random LOCKPICK = new Random();
            int ACIERTO = LOCKPICK.Next(1, 8);

            LINEA_SUPERIOR();
            POSITION = 1;
            IMPUTS1:
            Console.ResetColor();
            var INPUT = Console.ReadKey();
            switch (INPUT.Key)
            {
                case ConsoleKey.LeftArrow:                     //CONDICIONES DE IZQUIERDA
                    if (POSITION == 1)
                    {
                        BORRAR_LINEA_SUPERIOR();
                        LINEA_DIAGONAL_SUPERIOR_IZQUIERDA();
                        POSITION = 8;
                        goto IMPUTS1;
                    }
                    if (POSITION == 8)
                    {
                        BORRAR_LINEA_DIAGONAL_SUPERIOR_IZQUIERDA();
                        LINEA_IZQUIERDA();
                        POSITION = 7;
                        goto IMPUTS1;
                    }
                    if (POSITION == 7)
                    {
                        BORRAR_LINEA_IZQUIERDA();
                        LINEA_DIAGONAL_INFERIOR_IZQUIERDA();
                        POSITION = 6;
                        goto IMPUTS1;
                    }
                    if (POSITION == 6)
                    {
                        BORRAR_LINEA_DIAGONAL_INFERIOR_IZQUIERDA();
                        LINEA_INFERIOR();
                        POSITION = 5;
                        goto IMPUTS1;
                    }
                    if (POSITION == 5)
                    {
                        BORRAR_LINEA_INFERIOR();
                        LINEA_DIAGONAL_INFERIOR_DERECHA();
                        POSITION = 4;
                        goto IMPUTS1;
                    }
                    if (POSITION == 4)
                    {
                        BORRAR_LINEA_DIAGONAL_INFERIOR_DERECHA();
                        LINEA_DERECHA();
                        POSITION = 3;
                        goto IMPUTS1;
                    }
                    if (POSITION == 3)
                    {
                        BORRAR_LINEA_DERECHA();
                        LINEA_DIAGONAL_SUPERIOR_DERECHA();
                        POSITION = 2;
                        goto IMPUTS1;
                    }
                    if (POSITION == 2)
                    {
                        BORRAR_LINEA_DIAGONAL_SUPERIOR_DERECHA();
                        LINEA_SUPERIOR();
                        POSITION = 1;
                        goto IMPUTS1;
                    }
                    goto IMPUTS1;

                case ConsoleKey.RightArrow:                                  //CONDICIONES DE DERECHA
                    if (POSITION == 1)
                    {
                        BORRAR_LINEA_SUPERIOR();
                        LINEA_DIAGONAL_SUPERIOR_DERECHA();
                        POSITION = 2;
                        goto IMPUTS1;
                    }
                    if (POSITION == 2)
                    {
                        BORRAR_LINEA_DIAGONAL_SUPERIOR_DERECHA();
                        LINEA_DERECHA();
                        POSITION = 3;
                        goto IMPUTS1;
                    }
                    if (POSITION == 3)
                    {
                        BORRAR_LINEA_DERECHA();
                        LINEA_DIAGONAL_INFERIOR_DERECHA();
                        POSITION = 4;
                        goto IMPUTS1;
                    }
                    if (POSITION == 4)
                    {
                        BORRAR_LINEA_DIAGONAL_INFERIOR_DERECHA();
                        LINEA_INFERIOR();
                        POSITION = 5;
                        goto IMPUTS1;
                    }
                    if (POSITION == 5)
                    {
                        BORRAR_LINEA_INFERIOR();
                        LINEA_DIAGONAL_INFERIOR_IZQUIERDA();
                        POSITION = 6;
                        goto IMPUTS1;
                    }
                    if (POSITION == 6)
                    {
                        BORRAR_LINEA_DIAGONAL_INFERIOR_IZQUIERDA();
                        LINEA_IZQUIERDA();
                        POSITION = 7;
                        goto IMPUTS1;
                    }
                    if (POSITION == 7)
                    {
                        BORRAR_LINEA_IZQUIERDA();
                        LINEA_DIAGONAL_SUPERIOR_IZQUIERDA();
                        POSITION = 8;
                        goto IMPUTS1;
                    }
                    if (POSITION == 8)
                    {
                        BORRAR_LINEA_DIAGONAL_SUPERIOR_IZQUIERDA();
                        LINEA_SUPERIOR();
                        POSITION = 1;
                        goto IMPUTS1;
                    }
                    goto IMPUTS1;
                case ConsoleKey.Enter:
                    Console.SetCursorPosition(3, 10 + A);
                    Console.Write("Has probado forzar la cerradura..");
                    A = A + 1;
                    int C1 = POSITION;
                    int C2 = ACIERTO;
                    if (C1 == C2)
                    {
                        BARRA_VERDE();
                        Console.SetCursorPosition(3, 10 + A);
                        Console.Write("¡Has forzado la cerradura!");
                        A = A + 1;
                        break;
                    }
                    else
                    {
                        Console.SetCursorPosition(3, 10 + A);
                        Console.Write("incorrecto...");
                        A = A + 1;
                        Console.SetCursorPosition(3, 10 + A);
                        Console.Write("Te quedan {0}/4 intentos", B);
                        B = B - 1;
                        A = A + 1;                                        //COLORES DE PROBABILIDAD DE LA BARRA

                        if (B == -1)
                        {
                            Console.SetCursorPosition(3, 10 + A);
                            Console.Write("HAS PERDIDO");
                            A = A + 1;
                            Thread.Sleep(2000);
                            Console.SetCursorPosition(3, 10 + A);
                            Console.Write("HAS ACTIVADO LA ALARMA");
                            A = A + 1;
                            Thread.Sleep(4000);
                            JUEGO_4();
                            break;
                        }
                        if (B > -1)
                        {
                            if (C1 == 1)
                            {
                                if (C2 == 8)
                                {
                                    BARRA_VERDE_OSCURO();
                                }
                                else if (C2 == 2)
                                {
                                    BARRA_VERDE_OSCURO();
                                }
                                else if (C2 == 7)
                                {
                                    BARRA_AMARILLA();
                                }
                                else if (C2 == 3)
                                {
                                    BARRA_AMARILLA();
                                }
                                else if ((C2 == 4) || (C2 == 5) || (C2 == 6))
                                {
                                    BARRA_ROJA();
                                }
                            }
                            if (C1 == 2)
                            {
                                if (C2 == 1)
                                {
                                    BARRA_VERDE_OSCURO();
                                }
                                else if (C2 == 3)
                                {
                                    BARRA_VERDE_OSCURO();
                                }
                                else if (C2 == 8)
                                {
                                    BARRA_AMARILLA();
                                }
                                else if (C2 == 4)
                                {
                                    BARRA_AMARILLA();
                                }
                                else if ((C2 == 5) || (C2 == 6) || (C2 == 7))
                                {
                                    BARRA_ROJA();
                                }
                            }
                            if (C1 == 3)
                            {
                                if (C2 == 2)
                                {
                                    BARRA_VERDE_OSCURO();
                                }
                                else if (C2 == 4)
                                {
                                    BARRA_VERDE_OSCURO();
                                }
                                else if (C2 == 1)
                                {
                                    BARRA_AMARILLA();
                                }
                                else if (C2 == 5)
                                {
                                    BARRA_AMARILLA();
                                }
                                else if ((C2 == 6) || (C2 == 7) || (C2 == 8))
                                {
                                    BARRA_ROJA();
                                }
                            }
                            if (C1 == 4)
                            {
                                if (C2 == 3)
                                {
                                    BARRA_VERDE_OSCURO();
                                }
                                else if (C2 == 5)
                                {
                                    BARRA_VERDE_OSCURO();
                                }
                                else if (C2 == 2)
                                {
                                    BARRA_AMARILLA();
                                }
                                else if (C2 == 6)
                                {
                                    BARRA_AMARILLA();
                                }
                                else if ((C2 == 7) || (C2 == 8) || (C2 == 1))
                                {
                                    BARRA_ROJA();
                                }
                            }
                            if (C1 == 5)
                            {
                                if (C2 == 4)
                                {
                                    BARRA_VERDE_OSCURO();
                                }
                                else if (C2 == 6)
                                {
                                    BARRA_VERDE_OSCURO();
                                }
                                else if (C2 == 3)
                                {
                                    BARRA_AMARILLA();
                                }
                                else if (C2 == 7)
                                {
                                    BARRA_AMARILLA();
                                }
                                else if ((C2 == 8) || (C2 == 1) || (C2 == 2))
                                {
                                    BARRA_ROJA();
                                }
                            }
                            if (C1 == 6)
                            {
                                if (C2 == 5)
                                {
                                    BARRA_VERDE_OSCURO();
                                }
                                else if (C2 == 7)
                                {
                                    BARRA_VERDE_OSCURO();
                                }
                                else if (C2 == 4)
                                {
                                    BARRA_AMARILLA();
                                }
                                else if (C2 == 8)
                                {
                                    BARRA_AMARILLA();
                                }
                                else if ((C2 == 1) || (C2 == 2) || (C2 == 3))
                                {
                                    BARRA_ROJA();
                                }
                            }
                            if (C1 == 7)
                            {
                                if (C2 == 6)
                                {
                                    BARRA_VERDE_OSCURO();
                                }
                                else if (C2 == 8)
                                {
                                    BARRA_VERDE_OSCURO();
                                }
                                else if (C2 == 5)
                                {
                                    BARRA_AMARILLA();
                                }
                                else if (C2 == 1)
                                {
                                    BARRA_AMARILLA();
                                }
                                else if ((C2 == 2) || (C2 == 3) || (C2 == 4))
                                {
                                    BARRA_ROJA();
                                }
                            }
                            if (C1 == 8)
                            {
                                if (C2 == 7)
                                {
                                    BARRA_VERDE_OSCURO();
                                }
                                else if (C2 == 1)
                                {
                                    BARRA_VERDE_OSCURO();
                                }
                                else if (C2 == 6)
                                {
                                    BARRA_AMARILLA();
                                }
                                else if (C2 == 2)
                                {
                                    BARRA_AMARILLA();
                                }
                                else if ((C2 == 3) || (C2 == 4) || (C2 == 5))
                                {
                                    BARRA_ROJA();
                                }
                            }
                        }
                    }
                    goto IMPUTS1;
            }
        }                                     //LOCKPICK

        static void Mapa1_1()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            PANTALLA();
            INTERFAZ_2();
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i <= 26; i++)      // vertical interior izquierda 
            {
                Console.SetCursorPosition(65, (i + 7));
                Console.WriteLine("█");
            }
            for (int i = 0; i <= 62; i++)
            {
                Console.SetCursorPosition((i + 44), 15);
                Console.WriteLine("█");
            }
            for (int i = 0; i <= 62; i++)
            {
                Console.SetCursorPosition((i + 44), 24);
                Console.WriteLine("█");
            }
            for (int i = 0; i <= 26; i++)  //vertical interior derecha
            {
                Console.SetCursorPosition(86, (i + 7));
                Console.WriteLine("█");
            }
            for (int i = 0; i <= 62; i++) //horizontal superior
            {
                Console.SetCursorPosition((i + 44), 6);
                Console.WriteLine("█");
            }
            for (int i = 0; i <= 26; i++) //vertical izquierda
            {
                Console.SetCursorPosition(44, (i + 6));
                Console.WriteLine("█");
            }
            for (int i = 0; i <= 62; i++) //horizontal inferior
            {
                Console.SetCursorPosition((i + 44), 33);
                Console.WriteLine("█");
            }
            for (int i = 0; i <= 26; i++)  //vertical derecha
            {
                Console.SetCursorPosition(106, (i + 6));
                Console.WriteLine("█");
            }
            //ELEMENTOS EN EL MAPA
            Console.ForegroundColor = ConsoleColor.DarkYellow;  //PUERTA ENTRADA PRINCIPAL
            Console.SetCursorPosition(52, 6);
            Console.WriteLine("═════");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(50, 5);
            Console.WriteLine("█       █");
            Console.ForegroundColor = ConsoleColor.DarkBlue;  //PUERTA ENTRADA PRINCIPAL
            Console.SetCursorPosition(52, 33);
            Console.WriteLine("═════");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(50, 34);
            Console.WriteLine("█       █");
            Console.SetCursorPosition(50, 35);
            Console.WriteLine("█       █");
            Console.SetCursorPosition(65, 13);
            Console.ForegroundColor = ConsoleColor.DarkBlue;    //PUERTA SUPERIOR IZQUIERDA     
            Console.WriteLine("║");
            Console.SetCursorPosition(86, 13);
            Console.ForegroundColor = ConsoleColor.DarkBlue;  //PUERTA SUPERIOR CENTRO
            Console.WriteLine("║");
            Console.SetCursorPosition(65, 22);
            Console.ForegroundColor = ConsoleColor.DarkYellow;   //PUERTA MEDIA IZQUIERDA
            Console.WriteLine("║");
            Console.SetCursorPosition(86, 26);
            Console.ForegroundColor = ConsoleColor.DarkBlue;  //PUERTA INFERIOR DERECHA (IZQUIERDA)
            Console.WriteLine("║");
            Console.SetCursorPosition(100, 24);
            Console.ForegroundColor = ConsoleColor.DarkBlue;  //PUERTA INFERIOR DERECHA (ARRIBA)
            Console.WriteLine("══");
            Console.SetCursorPosition(100, 15);
            Console.ForegroundColor = ConsoleColor.DarkYellow;  //PUERTA SUPERIOR DERECHA (ABAJO)
            Console.WriteLine("══");
            Console.SetCursorPosition(70, 24);
            Console.ForegroundColor = ConsoleColor.DarkYellow;   //PUERTA MEDIO ARRIBA
            Console.WriteLine("══");
            Console.SetCursorPosition(48, 24);
            Console.ForegroundColor = ConsoleColor.DarkYellow;   //PUERTA IZQUIERDA ARRIBA
            Console.WriteLine("══");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(88, 8);       //CAJA FUERTE
            Console.WriteLine("╔═════╗");
            Console.SetCursorPosition(88, 9);
            Console.WriteLine("║╔═╦═╗║");
            Console.SetCursorPosition(88, 10);
            Console.WriteLine("║╠═O═╣║");
            Console.SetCursorPosition(88, 11);
            Console.WriteLine("║╚═╩═╝║");
            Console.SetCursorPosition(88, 12);
            Console.WriteLine("╚═════╝");
            Console.ForegroundColor = ConsoleColor.Gray;   //COMPUTADORAS
            Console.SetCursorPosition(67, 8);
            Console.WriteLine("╔══════╗");
            Console.SetCursorPosition(67, 9);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(67, 10);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(67, 11);
            Console.WriteLine("╚══╦╦══╝");
            Console.SetCursorPosition(67, 12);
            Console.WriteLine("╔╦╦╦╦╦╦╗");
            Console.SetCursorPosition(67, 13);
            Console.WriteLine("╚╩╩╩╩╩╩╝");
            Console.SetCursorPosition(46, 26);
            Console.WriteLine("╔══════╗");
            Console.SetCursorPosition(46, 27);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(46, 28);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(46, 29);
            Console.WriteLine("╚══╦╦══╝");
            Console.SetCursorPosition(46, 30);
            Console.WriteLine("╔╦╦╦╦╦╦╗");
            Console.SetCursorPosition(46, 31);
            Console.WriteLine("╚╩╩╩╩╩╩╝");
            Console.SetCursorPosition(46, 8);
            Console.WriteLine("╔══════╗");
            Console.SetCursorPosition(46, 9);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(46, 10);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(46, 11);
            Console.WriteLine("╚══╦╦══╝");
            Console.SetCursorPosition(46, 12);
            Console.WriteLine("╔╦╦╦╦╦╦╗");
            Console.SetCursorPosition(46, 13);
            Console.WriteLine("╚╩╩╩╩╩╩╝");
            Console.SetCursorPosition(46, 17);
            Console.WriteLine("╔══════╗");
            Console.SetCursorPosition(46, 18);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(46, 19);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(46, 20);
            Console.WriteLine("╚══╦╦══╝");
            Console.SetCursorPosition(46, 21);
            Console.WriteLine("╔╦╦╦╦╦╦╗");
            Console.SetCursorPosition(46, 22);
            Console.WriteLine("╚╩╩╩╩╩╩╝");
            Console.SetCursorPosition(67, 17);
            Console.WriteLine("╔══════╗");
            Console.SetCursorPosition(67, 18);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(67, 19);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(67, 20);
            Console.WriteLine("╚══╦╦══╝");
            Console.SetCursorPosition(67, 21);
            Console.WriteLine("╔╦╦╦╦╦╦╗");
            Console.SetCursorPosition(67, 22);
            Console.WriteLine("╚╩╩╩╩╩╩╝");
            Console.SetCursorPosition(88, 17);
            Console.WriteLine("╔══════╗");
            Console.SetCursorPosition(88, 18);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(88, 19);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(88, 20);
            Console.WriteLine("╚══╦╦══╝");
            Console.SetCursorPosition(88, 21);
            Console.WriteLine("╔╦╦╦╦╦╦╗");
            Console.SetCursorPosition(88, 22);
            Console.WriteLine("╚╩╩╩╩╩╩╝");
            Console.ResetColor();
            Console.SetCursorPosition(58, 10);
            Console.WriteLine(" n-n");
            Console.SetCursorPosition(58, 11);
            Console.WriteLine(" ┌|┐");
            Console.SetCursorPosition(58, 12);
            Console.WriteLine("  | ");
            Console.SetCursorPosition(58, 13);
            Console.WriteLine(" / \\");
            Thread.Sleep(5000);
        }    //PASAR TODOS LOS MAPAS A CHANGO
        static void Mapa1_2()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            PANTALLA();
            INTERFAZ_2();
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i <= 26; i++)      // vertical interior izquierda 
            {
                Console.SetCursorPosition(65, (i + 7));
                Console.WriteLine("█");
            }
            for (int i = 0; i <= 62; i++)
            {
                Console.SetCursorPosition((i + 44), 15);
                Console.WriteLine("█");
            }
            for (int i = 0; i <= 62; i++)
            {
                Console.SetCursorPosition((i + 44), 24);
                Console.WriteLine("█");
            }
            for (int i = 0; i <= 26; i++)  //vertical interior derecha
            {
                Console.SetCursorPosition(86, (i + 7));
                Console.WriteLine("█");
            }
            for (int i = 0; i <= 62; i++) //horizontal superior
            {
                Console.SetCursorPosition((i + 44), 6);
                Console.WriteLine("█");
            }
            for (int i = 0; i <= 26; i++) //vertical izquierda
            {
                Console.SetCursorPosition(44, (i + 6));
                Console.WriteLine("█");
            }
            for (int i = 0; i <= 62; i++) //horizontal inferior
            {
                Console.SetCursorPosition((i + 44), 33);
                Console.WriteLine("█");
            }
            for (int i = 0; i <= 26; i++)  //vertical derecha
            {
                Console.SetCursorPosition(106, (i + 6));
                Console.WriteLine("█");
            }
            //ELEMENTOS EN EL MAPA
            Console.ForegroundColor = ConsoleColor.DarkYellow;  //PUERTA ENTRADA PRINCIPAL
            Console.SetCursorPosition(52, 6);
            Console.WriteLine("═════");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(50, 5);
            Console.WriteLine("█       █");
            Console.ForegroundColor = ConsoleColor.DarkBlue;  //PUERTA ENTRADA PRINCIPAL
            Console.SetCursorPosition(52, 33);
            Console.WriteLine("═════");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(50, 34);
            Console.WriteLine("█       █");
            Console.SetCursorPosition(50, 35);
            Console.WriteLine("█       █");
            Console.SetCursorPosition(65, 13);
            Console.ForegroundColor = ConsoleColor.DarkBlue;    //PUERTA SUPERIOR IZQUIERDA     
            Console.WriteLine("║");
            Console.SetCursorPosition(86, 13);
            Console.ForegroundColor = ConsoleColor.DarkBlue;  //PUERTA SUPERIOR CENTRO
            Console.WriteLine("║");
            Console.SetCursorPosition(65, 22);
            Console.ForegroundColor = ConsoleColor.DarkYellow;   //PUERTA MEDIA IZQUIERDA
            Console.WriteLine("║");
            Console.SetCursorPosition(86, 26);
            Console.ForegroundColor = ConsoleColor.DarkBlue;  //PUERTA INFERIOR DERECHA (IZQUIERDA)
            Console.WriteLine("║");
            Console.SetCursorPosition(100, 24);
            Console.ForegroundColor = ConsoleColor.DarkBlue;  //PUERTA INFERIOR DERECHA (ARRIBA)
            Console.WriteLine("══");
            Console.SetCursorPosition(100, 15);
            Console.ForegroundColor = ConsoleColor.DarkYellow;  //PUERTA SUPERIOR DERECHA (ABAJO)
            Console.WriteLine("══");
            Console.SetCursorPosition(70, 24);
            Console.ForegroundColor = ConsoleColor.DarkYellow;   //PUERTA MEDIO ARRIBA
            Console.WriteLine("══");
            Console.SetCursorPosition(48, 24);
            Console.ForegroundColor = ConsoleColor.DarkYellow;   //PUERTA IZQUIERDA ARRIBA
            Console.WriteLine("══");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(88, 8);       //CAJA FUERTE
            Console.WriteLine("╔═════╗");
            Console.SetCursorPosition(88, 9);
            Console.WriteLine("║╔═╦═╗║");
            Console.SetCursorPosition(88, 10);
            Console.WriteLine("║╠═O═╣║");
            Console.SetCursorPosition(88, 11);
            Console.WriteLine("║╚═╩═╝║");
            Console.SetCursorPosition(88, 12);
            Console.WriteLine("╚═════╝");
            Console.ForegroundColor = ConsoleColor.Gray;   //COMPUTADORAS
            Console.SetCursorPosition(67, 8);
            Console.WriteLine("╔══════╗");
            Console.SetCursorPosition(67, 9);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(67, 10);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(67, 11);
            Console.WriteLine("╚══╦╦══╝");
            Console.SetCursorPosition(67, 12);
            Console.WriteLine("╔╦╦╦╦╦╦╗");
            Console.SetCursorPosition(67, 13);
            Console.WriteLine("╚╩╩╩╩╩╩╝");
            Console.SetCursorPosition(46, 26);
            Console.WriteLine("╔══════╗");
            Console.SetCursorPosition(46, 27);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(46, 28);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(46, 29);
            Console.WriteLine("╚══╦╦══╝");
            Console.SetCursorPosition(46, 30);
            Console.WriteLine("╔╦╦╦╦╦╦╗");
            Console.SetCursorPosition(46, 31);
            Console.WriteLine("╚╩╩╩╩╩╩╝");
            Console.SetCursorPosition(46, 8);
            Console.WriteLine("╔══════╗");
            Console.SetCursorPosition(46, 9);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(46, 10);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(46, 11);
            Console.WriteLine("╚══╦╦══╝");
            Console.SetCursorPosition(46, 12);
            Console.WriteLine("╔╦╦╦╦╦╦╗");
            Console.SetCursorPosition(46, 13);
            Console.WriteLine("╚╩╩╩╩╩╩╝");
            Console.SetCursorPosition(46, 17);
            Console.WriteLine("╔══════╗");
            Console.SetCursorPosition(46, 18);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(46, 19);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(46, 20);
            Console.WriteLine("╚══╦╦══╝");
            Console.SetCursorPosition(46, 21);
            Console.WriteLine("╔╦╦╦╦╦╦╗");
            Console.SetCursorPosition(46, 22);
            Console.WriteLine("╚╩╩╩╩╩╩╝");
            Console.SetCursorPosition(67, 17);
            Console.WriteLine("╔══════╗");
            Console.SetCursorPosition(67, 18);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(67, 19);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(67, 20);
            Console.WriteLine("╚══╦╦══╝");
            Console.SetCursorPosition(67, 21);
            Console.WriteLine("╔╦╦╦╦╦╦╗");
            Console.SetCursorPosition(67, 22);
            Console.WriteLine("╚╩╩╩╩╩╩╝");
            Console.SetCursorPosition(88, 17);
            Console.WriteLine("╔══════╗");
            Console.SetCursorPosition(88, 18);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(88, 19);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(88, 20);
            Console.WriteLine("╚══╦╦══╝");
            Console.SetCursorPosition(88, 21);
            Console.WriteLine("╔╦╦╦╦╦╦╗");
            Console.SetCursorPosition(88, 22);
            Console.WriteLine("╚╩╩╩╩╩╩╝");
            Console.ResetColor();
            Console.SetCursorPosition(78, 10);
            Console.WriteLine(" n-n");
            Console.SetCursorPosition(78, 11);
            Console.WriteLine(" ┌|┐");
            Console.SetCursorPosition(78, 12);
            Console.WriteLine("  | ");
            Console.SetCursorPosition(78, 13);
            Console.WriteLine(" / \\");
            Thread.Sleep(5000);
        }
        static void Mapa1_3()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            PANTALLA();
            INTERFAZ_2();
            {
                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 0; i <= 26; i++)      // vertical interior izquierda 
                {
                    Console.SetCursorPosition(65, (i + 7));
                    Console.WriteLine("█");
                }
                for (int i = 0; i <= 62; i++)
                {
                    Console.SetCursorPosition((i + 44), 15);
                    Console.WriteLine("█");
                }
                for (int i = 0; i <= 62; i++)
                {
                    Console.SetCursorPosition((i + 44), 24);
                    Console.WriteLine("█");
                }
                for (int i = 0; i <= 26; i++)  //vertical interior derecha
                {
                    Console.SetCursorPosition(86, (i + 7));
                    Console.WriteLine("█");
                }
                for (int i = 0; i <= 62; i++) //horizontal superior
                {
                    Console.SetCursorPosition((i + 44), 6);
                    Console.WriteLine("█");
                }
                for (int i = 0; i <= 26; i++) //vertical izquierda
                {
                    Console.SetCursorPosition(44, (i + 6));
                    Console.WriteLine("█");
                }
                for (int i = 0; i <= 62; i++) //horizontal inferior
                {
                    Console.SetCursorPosition((i + 44), 33);
                    Console.WriteLine("█");
                }
                for (int i = 0; i <= 26; i++)  //vertical derecha
                {
                    Console.SetCursorPosition(106, (i + 6));
                    Console.WriteLine("█");
                }
                //ELEMENTOS EN EL MAPA
                Console.ForegroundColor = ConsoleColor.DarkYellow;  //PUERTA ENTRADA PRINCIPAL
                Console.SetCursorPosition(52, 6);
                Console.WriteLine("═════");
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(50, 5);
                Console.WriteLine("█       █");
                Console.ForegroundColor = ConsoleColor.DarkBlue;  //PUERTA ENTRADA PRINCIPAL
                Console.SetCursorPosition(52, 33);
                Console.WriteLine("═════");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(50, 34);
                Console.WriteLine("█       █");
                Console.SetCursorPosition(50, 35);
                Console.WriteLine("█       █");
                Console.SetCursorPosition(65, 13);
                Console.ForegroundColor = ConsoleColor.DarkBlue;    //PUERTA SUPERIOR IZQUIERDA     
                Console.WriteLine("║");
                Console.SetCursorPosition(86, 13);
                Console.ForegroundColor = ConsoleColor.DarkBlue;  //PUERTA SUPERIOR CENTRO
                Console.WriteLine("║");
                Console.SetCursorPosition(65, 22);
                Console.ForegroundColor = ConsoleColor.DarkYellow;   //PUERTA MEDIA IZQUIERDA
                Console.WriteLine("║");
                Console.SetCursorPosition(86, 26);
                Console.ForegroundColor = ConsoleColor.DarkBlue;  //PUERTA INFERIOR DERECHA (IZQUIERDA)
                Console.WriteLine("║");
                Console.SetCursorPosition(100, 24);
                Console.ForegroundColor = ConsoleColor.DarkBlue;  //PUERTA INFERIOR DERECHA (ARRIBA)
                Console.WriteLine("══");
                Console.SetCursorPosition(100, 15);
                Console.ForegroundColor = ConsoleColor.DarkYellow;  //PUERTA SUPERIOR DERECHA (ABAJO)
                Console.WriteLine("══");
                Console.SetCursorPosition(70, 24);
                Console.ForegroundColor = ConsoleColor.DarkYellow;   //PUERTA MEDIO ARRIBA
                Console.WriteLine("══");
                Console.SetCursorPosition(48, 24);
                Console.ForegroundColor = ConsoleColor.DarkYellow;   //PUERTA IZQUIERDA ARRIBA
                Console.WriteLine("══");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.SetCursorPosition(88, 8);       //CAJA FUERTE
                Console.WriteLine("╔═════╗");
                Console.SetCursorPosition(88, 9);
                Console.WriteLine("║╔═╦═╗║");
                Console.SetCursorPosition(88, 10);
                Console.WriteLine("║╠═O═╣║");
                Console.SetCursorPosition(88, 11);
                Console.WriteLine("║╚═╩═╝║");
                Console.SetCursorPosition(88, 12);
                Console.WriteLine("╚═════╝");
                Console.ForegroundColor = ConsoleColor.Gray;   //COMPUTADORAS
                Console.SetCursorPosition(67, 8);
                Console.WriteLine("╔══════╗");
                Console.SetCursorPosition(67, 9);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(67, 10);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(67, 11);
                Console.WriteLine("╚══╦╦══╝");
                Console.SetCursorPosition(67, 12);
                Console.WriteLine("╔╦╦╦╦╦╦╗");
                Console.SetCursorPosition(67, 13);
                Console.WriteLine("╚╩╩╩╩╩╩╝");
                Console.SetCursorPosition(46, 26);
                Console.WriteLine("╔══════╗");
                Console.SetCursorPosition(46, 27);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(46, 28);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(46, 29);
                Console.WriteLine("╚══╦╦══╝");
                Console.SetCursorPosition(46, 30);
                Console.WriteLine("╔╦╦╦╦╦╦╗");
                Console.SetCursorPosition(46, 31);
                Console.WriteLine("╚╩╩╩╩╩╩╝");
                Console.SetCursorPosition(46, 8);
                Console.WriteLine("╔══════╗");
                Console.SetCursorPosition(46, 9);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(46, 10);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(46, 11);
                Console.WriteLine("╚══╦╦══╝");
                Console.SetCursorPosition(46, 12);
                Console.WriteLine("╔╦╦╦╦╦╦╗");
                Console.SetCursorPosition(46, 13);
                Console.WriteLine("╚╩╩╩╩╩╩╝");
                Console.SetCursorPosition(46, 17);
                Console.WriteLine("╔══════╗");
                Console.SetCursorPosition(46, 18);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(46, 19);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(46, 20);
                Console.WriteLine("╚══╦╦══╝");
                Console.SetCursorPosition(46, 21);
                Console.WriteLine("╔╦╦╦╦╦╦╗");
                Console.SetCursorPosition(46, 22);
                Console.WriteLine("╚╩╩╩╩╩╩╝");
                Console.SetCursorPosition(67, 17);
                Console.WriteLine("╔══════╗");
                Console.SetCursorPosition(67, 18);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(67, 19);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(67, 20);
                Console.WriteLine("╚══╦╦══╝");
                Console.SetCursorPosition(67, 21);
                Console.WriteLine("╔╦╦╦╦╦╦╗");
                Console.SetCursorPosition(67, 22);
                Console.WriteLine("╚╩╩╩╩╩╩╝");
                Console.SetCursorPosition(88, 17);
                Console.WriteLine("╔══════╗");
                Console.SetCursorPosition(88, 18);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(88, 19);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(88, 20);
                Console.WriteLine("╚══╦╦══╝");
                Console.SetCursorPosition(88, 21);
                Console.WriteLine("╔╦╦╦╦╦╦╗");
                Console.SetCursorPosition(88, 22);
                Console.WriteLine("╚╩╩╩╩╩╩╝");
                Console.ResetColor();
                Console.SetCursorPosition(98, 10);
                Console.WriteLine(" 0u0");
                Console.SetCursorPosition(98, 11);
                Console.WriteLine(" \\|/");
                Console.SetCursorPosition(98, 12);
                Console.WriteLine("  | ");
                Console.SetCursorPosition(98, 13);
                Console.WriteLine(" / \\");
                Thread.Sleep(5000);
            }
        }
        static void Mapa2_1()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            PANTALLA();
            INTERFAZ_2();
            {
                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 0; i <= 26; i++)      // vertical interior izquierda 
                {
                    Console.SetCursorPosition(65, (i + 7));
                    Console.WriteLine("█");
                }
                for (int i = 0; i <= 62; i++)
                {
                    Console.SetCursorPosition((i + 44), 15);
                    Console.WriteLine("█");
                }
                for (int i = 0; i <= 62; i++)
                {
                    Console.SetCursorPosition((i + 44), 24);
                    Console.WriteLine("█");
                }
                for (int i = 0; i <= 26; i++)  //vertical interior derecha
                {
                    Console.SetCursorPosition(86, (i + 7));
                    Console.WriteLine("█");
                }
                for (int i = 0; i <= 62; i++) //horizontal superior
                {
                    Console.SetCursorPosition((i + 44), 6);
                    Console.WriteLine("█");
                }
                for (int i = 0; i <= 26; i++) //vertical izquierda
                {
                    Console.SetCursorPosition(44, (i + 6));
                    Console.WriteLine("█");
                }
                for (int i = 0; i <= 62; i++) //horizontal inferior
                {
                    Console.SetCursorPosition((i + 44), 33);
                    Console.WriteLine("█");
                }
                for (int i = 0; i <= 26; i++)  //vertical derecha
                {
                    Console.SetCursorPosition(106, (i + 6));
                    Console.WriteLine("█");
                }
                //ELEMENTOS EN EL MAPA
                Console.ForegroundColor = ConsoleColor.DarkYellow;  //PUERTA ENTRADA PRINCIPAL
                Console.SetCursorPosition(52, 6);
                Console.WriteLine("═════");
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(50, 5);
                Console.WriteLine("█       █");
                Console.ForegroundColor = ConsoleColor.DarkBlue;  //PUERTA ENTRADA PRINCIPAL
                Console.SetCursorPosition(52, 33);
                Console.WriteLine("═════");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(50, 34);
                Console.WriteLine("█       █");
                Console.SetCursorPosition(50, 35);
                Console.WriteLine("█       █");
                Console.SetCursorPosition(65, 13);
                Console.ForegroundColor = ConsoleColor.DarkBlue;    //PUERTA SUPERIOR IZQUIERDA     
                Console.WriteLine("║");
                Console.SetCursorPosition(86, 13);
                Console.ForegroundColor = ConsoleColor.DarkBlue;  //PUERTA SUPERIOR CENTRO
                Console.WriteLine("║");
                Console.SetCursorPosition(65, 22);
                Console.ForegroundColor = ConsoleColor.DarkYellow;   //PUERTA MEDIA IZQUIERDA
                Console.WriteLine("║");
                Console.SetCursorPosition(86, 26);
                Console.ForegroundColor = ConsoleColor.DarkBlue;  //PUERTA INFERIOR DERECHA (IZQUIERDA)
                Console.WriteLine("║");
                Console.SetCursorPosition(100, 24);
                Console.ForegroundColor = ConsoleColor.DarkBlue;  //PUERTA INFERIOR DERECHA (ARRIBA)
                Console.WriteLine("══");
                Console.SetCursorPosition(100, 15);
                Console.ForegroundColor = ConsoleColor.DarkYellow;  //PUERTA SUPERIOR DERECHA (ABAJO)
                Console.WriteLine("══");
                Console.SetCursorPosition(70, 24);
                Console.ForegroundColor = ConsoleColor.DarkYellow;   //PUERTA MEDIO ARRIBA
                Console.WriteLine("══");
                Console.SetCursorPosition(48, 24);
                Console.ForegroundColor = ConsoleColor.DarkYellow;   //PUERTA IZQUIERDA ARRIBA
                Console.WriteLine("══");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.SetCursorPosition(88, 8);       //CAJA FUERTE
                Console.WriteLine("╔═════╗");
                Console.SetCursorPosition(88, 9);
                Console.WriteLine("║╔═╦═╗║");
                Console.SetCursorPosition(88, 10);
                Console.WriteLine("║╠═O═╣║");
                Console.SetCursorPosition(88, 11);
                Console.WriteLine("║╚═╩═╝║");
                Console.SetCursorPosition(88, 12);
                Console.WriteLine("╚═════╝");
                Console.ForegroundColor = ConsoleColor.Gray;   //COMPUTADORAS
                Console.SetCursorPosition(67, 8);
                Console.WriteLine("╔══════╗");
                Console.SetCursorPosition(67, 9);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(67, 10);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(67, 11);
                Console.WriteLine("╚══╦╦══╝");
                Console.SetCursorPosition(67, 12);
                Console.WriteLine("╔╦╦╦╦╦╦╗");
                Console.SetCursorPosition(67, 13);
                Console.WriteLine("╚╩╩╩╩╩╩╝");
                Console.SetCursorPosition(46, 26);
                Console.WriteLine("╔══════╗");
                Console.SetCursorPosition(46, 27);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(46, 28);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(46, 29);
                Console.WriteLine("╚══╦╦══╝");
                Console.SetCursorPosition(46, 30);
                Console.WriteLine("╔╦╦╦╦╦╦╗");
                Console.SetCursorPosition(46, 31);
                Console.WriteLine("╚╩╩╩╩╩╩╝");
                Console.SetCursorPosition(46, 8);
                Console.WriteLine("╔══════╗");
                Console.SetCursorPosition(46, 9);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(46, 10);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(46, 11);
                Console.WriteLine("╚══╦╦══╝");
                Console.SetCursorPosition(46, 12);
                Console.WriteLine("╔╦╦╦╦╦╦╗");
                Console.SetCursorPosition(46, 13);
                Console.WriteLine("╚╩╩╩╩╩╩╝");
                Console.SetCursorPosition(46, 17);
                Console.WriteLine("╔══════╗");
                Console.SetCursorPosition(46, 18);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(46, 19);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(46, 20);
                Console.WriteLine("╚══╦╦══╝");
                Console.SetCursorPosition(46, 21);
                Console.WriteLine("╔╦╦╦╦╦╦╗");
                Console.SetCursorPosition(46, 22);
                Console.WriteLine("╚╩╩╩╩╩╩╝");
                Console.SetCursorPosition(67, 17);
                Console.WriteLine("╔══════╗");
                Console.SetCursorPosition(67, 18);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(67, 19);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(67, 20);
                Console.WriteLine("╚══╦╦══╝");
                Console.SetCursorPosition(67, 21);
                Console.WriteLine("╔╦╦╦╦╦╦╗");
                Console.SetCursorPosition(67, 22);
                Console.WriteLine("╚╩╩╩╩╩╩╝");
                Console.SetCursorPosition(88, 17);
                Console.WriteLine("╔══════╗");
                Console.SetCursorPosition(88, 18);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(88, 19);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(88, 20);
                Console.WriteLine("╚══╦╦══╝");
                Console.SetCursorPosition(88, 21);
                Console.WriteLine("╔╦╦╦╦╦╦╗");
                Console.SetCursorPosition(88, 22);
                Console.WriteLine("╚╩╩╩╩╩╩╝");
                Console.ResetColor();
                Console.SetCursorPosition(58, 19);
                Console.WriteLine(" n-n");
                Console.SetCursorPosition(58, 20);
                Console.WriteLine(" ┌|┐");
                Console.SetCursorPosition(58, 21);
                Console.WriteLine("  | ");
                Console.SetCursorPosition(58, 22);
                Console.WriteLine(" / \\");
                Thread.Sleep(5000);
            }
        }
        static void Mapa2_2()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            PANTALLA();
            INTERFAZ_2();
            {
                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 0; i <= 26; i++)      // vertical interior izquierda 
                {
                    Console.SetCursorPosition(65, (i + 7));
                    Console.WriteLine("█");
                }
                for (int i = 0; i <= 62; i++)
                {
                    Console.SetCursorPosition((i + 44), 15);
                    Console.WriteLine("█");
                }
                for (int i = 0; i <= 62; i++)
                {
                    Console.SetCursorPosition((i + 44), 24);
                    Console.WriteLine("█");
                }
                for (int i = 0; i <= 26; i++)  //vertical interior derecha
                {
                    Console.SetCursorPosition(86, (i + 7));
                    Console.WriteLine("█");
                }
                for (int i = 0; i <= 62; i++) //horizontal superior
                {
                    Console.SetCursorPosition((i + 44), 6);
                    Console.WriteLine("█");
                }
                for (int i = 0; i <= 26; i++) //vertical izquierda
                {
                    Console.SetCursorPosition(44, (i + 6));
                    Console.WriteLine("█");
                }
                for (int i = 0; i <= 62; i++) //horizontal inferior
                {
                    Console.SetCursorPosition((i + 44), 33);
                    Console.WriteLine("█");
                }
                for (int i = 0; i <= 26; i++)  //vertical derecha
                {
                    Console.SetCursorPosition(106, (i + 6));
                    Console.WriteLine("█");
                }
                //ELEMENTOS EN EL MAPA
                Console.ForegroundColor = ConsoleColor.DarkYellow;  //PUERTA ENTRADA PRINCIPAL
                Console.SetCursorPosition(52, 6);
                Console.WriteLine("═════");
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(50, 5);
                Console.WriteLine("█       █");
                Console.ForegroundColor = ConsoleColor.DarkBlue;  //PUERTA ENTRADA PRINCIPAL
                Console.SetCursorPosition(52, 33);
                Console.WriteLine("═════");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(50, 34);
                Console.WriteLine("█       █");
                Console.SetCursorPosition(50, 35);
                Console.WriteLine("█       █");
                Console.SetCursorPosition(65, 13);
                Console.ForegroundColor = ConsoleColor.DarkBlue;    //PUERTA SUPERIOR IZQUIERDA     
                Console.WriteLine("║");
                Console.SetCursorPosition(86, 13);
                Console.ForegroundColor = ConsoleColor.DarkBlue;  //PUERTA SUPERIOR CENTRO
                Console.WriteLine("║");
                Console.SetCursorPosition(65, 22);
                Console.ForegroundColor = ConsoleColor.DarkYellow;   //PUERTA MEDIA IZQUIERDA
                Console.WriteLine("║");
                Console.SetCursorPosition(86, 26);
                Console.ForegroundColor = ConsoleColor.DarkBlue;  //PUERTA INFERIOR DERECHA (IZQUIERDA)
                Console.WriteLine("║");
                Console.SetCursorPosition(100, 24);
                Console.ForegroundColor = ConsoleColor.DarkBlue;  //PUERTA INFERIOR DERECHA (ARRIBA)
                Console.WriteLine("══");
                Console.SetCursorPosition(100, 15);
                Console.ForegroundColor = ConsoleColor.DarkYellow;  //PUERTA SUPERIOR DERECHA (ABAJO)
                Console.WriteLine("══");
                Console.SetCursorPosition(70, 24);
                Console.ForegroundColor = ConsoleColor.DarkYellow;   //PUERTA MEDIO ARRIBA
                Console.WriteLine("══");
                Console.SetCursorPosition(48, 24);
                Console.ForegroundColor = ConsoleColor.DarkYellow;   //PUERTA IZQUIERDA ARRIBA
                Console.WriteLine("══");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.SetCursorPosition(88, 8);       //CAJA FUERTE
                Console.WriteLine("╔═════╗");
                Console.SetCursorPosition(88, 9);
                Console.WriteLine("║╔═╦═╗║");
                Console.SetCursorPosition(88, 10);
                Console.WriteLine("║╠═O═╣║");
                Console.SetCursorPosition(88, 11);
                Console.WriteLine("║╚═╩═╝║");
                Console.SetCursorPosition(88, 12);
                Console.WriteLine("╚═════╝");
                Console.ForegroundColor = ConsoleColor.Gray;   //COMPUTADORAS
                Console.SetCursorPosition(67, 8);
                Console.WriteLine("╔══════╗");
                Console.SetCursorPosition(67, 9);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(67, 10);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(67, 11);
                Console.WriteLine("╚══╦╦══╝");
                Console.SetCursorPosition(67, 12);
                Console.WriteLine("╔╦╦╦╦╦╦╗");
                Console.SetCursorPosition(67, 13);
                Console.WriteLine("╚╩╩╩╩╩╩╝");
                Console.SetCursorPosition(46, 26);
                Console.WriteLine("╔══════╗");
                Console.SetCursorPosition(46, 27);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(46, 28);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(46, 29);
                Console.WriteLine("╚══╦╦══╝");
                Console.SetCursorPosition(46, 30);
                Console.WriteLine("╔╦╦╦╦╦╦╗");
                Console.SetCursorPosition(46, 31);
                Console.WriteLine("╚╩╩╩╩╩╩╝");
                Console.SetCursorPosition(46, 8);
                Console.WriteLine("╔══════╗");
                Console.SetCursorPosition(46, 9);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(46, 10);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(46, 11);
                Console.WriteLine("╚══╦╦══╝");
                Console.SetCursorPosition(46, 12);
                Console.WriteLine("╔╦╦╦╦╦╦╗");
                Console.SetCursorPosition(46, 13);
                Console.WriteLine("╚╩╩╩╩╩╩╝");
                Console.SetCursorPosition(46, 17);
                Console.WriteLine("╔══════╗");
                Console.SetCursorPosition(46, 18);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(46, 19);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(46, 20);
                Console.WriteLine("╚══╦╦══╝");
                Console.SetCursorPosition(46, 21);
                Console.WriteLine("╔╦╦╦╦╦╦╗");
                Console.SetCursorPosition(46, 22);
                Console.WriteLine("╚╩╩╩╩╩╩╝");
                Console.SetCursorPosition(67, 17);
                Console.WriteLine("╔══════╗");
                Console.SetCursorPosition(67, 18);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(67, 19);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(67, 20);
                Console.WriteLine("╚══╦╦══╝");
                Console.SetCursorPosition(67, 21);
                Console.WriteLine("╔╦╦╦╦╦╦╗");
                Console.SetCursorPosition(67, 22);
                Console.WriteLine("╚╩╩╩╩╩╩╝");
                Console.SetCursorPosition(88, 17);
                Console.WriteLine("╔══════╗");
                Console.SetCursorPosition(88, 18);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(88, 19);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(88, 20);
                Console.WriteLine("╚══╦╦══╝");
                Console.SetCursorPosition(88, 21);
                Console.WriteLine("╔╦╦╦╦╦╦╗");
                Console.SetCursorPosition(88, 22);
                Console.WriteLine("╚╩╩╩╩╩╩╝");
                Console.ResetColor();
                Console.SetCursorPosition(78, 19);
                Console.WriteLine(" n-n");
                Console.SetCursorPosition(78, 20);
                Console.WriteLine(" ┌|┐");
                Console.SetCursorPosition(78, 21);
                Console.WriteLine("  | ");
                Console.SetCursorPosition(78, 22);
                Console.WriteLine(" / \\");
                Thread.Sleep(5000);
            }
        }
        static void Mapa2_3()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            PANTALLA();
            INTERFAZ_2();
            {
                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 0; i <= 26; i++)      // vertical interior izquierda 
                {
                    Console.SetCursorPosition(65, (i + 7));
                    Console.WriteLine("█");
                }
                for (int i = 0; i <= 62; i++)
                {
                    Console.SetCursorPosition((i + 44), 15);
                    Console.WriteLine("█");
                }
                for (int i = 0; i <= 62; i++)
                {
                    Console.SetCursorPosition((i + 44), 24);
                    Console.WriteLine("█");
                }
                for (int i = 0; i <= 26; i++)  //vertical interior derecha
                {
                    Console.SetCursorPosition(86, (i + 7));
                    Console.WriteLine("█");
                }
                for (int i = 0; i <= 62; i++) //horizontal superior
                {
                    Console.SetCursorPosition((i + 44), 6);
                    Console.WriteLine("█");
                }
                for (int i = 0; i <= 26; i++) //vertical izquierda
                {
                    Console.SetCursorPosition(44, (i + 6));
                    Console.WriteLine("█");
                }
                for (int i = 0; i <= 62; i++) //horizontal inferior
                {
                    Console.SetCursorPosition((i + 44), 33);
                    Console.WriteLine("█");
                }
                for (int i = 0; i <= 26; i++)  //vertical derecha
                {
                    Console.SetCursorPosition(106, (i + 6));
                    Console.WriteLine("█");
                }
                //ELEMENTOS EN EL MAPA
                Console.ForegroundColor = ConsoleColor.DarkYellow;  //PUERTA ENTRADA PRINCIPAL
                Console.SetCursorPosition(52, 6);
                Console.WriteLine("═════");
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(50, 5);
                Console.WriteLine("█       █");
                Console.ForegroundColor = ConsoleColor.DarkBlue;  //PUERTA ENTRADA PRINCIPAL
                Console.SetCursorPosition(52, 33);
                Console.WriteLine("═════");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(50, 34);
                Console.WriteLine("█       █");
                Console.SetCursorPosition(50, 35);
                Console.WriteLine("█       █");
                Console.SetCursorPosition(65, 13);
                Console.ForegroundColor = ConsoleColor.DarkBlue;    //PUERTA SUPERIOR IZQUIERDA     
                Console.WriteLine("║");
                Console.SetCursorPosition(86, 13);
                Console.ForegroundColor = ConsoleColor.DarkBlue;  //PUERTA SUPERIOR CENTRO
                Console.WriteLine("║");
                Console.SetCursorPosition(65, 22);
                Console.ForegroundColor = ConsoleColor.DarkYellow;   //PUERTA MEDIA IZQUIERDA
                Console.WriteLine("║");
                Console.SetCursorPosition(86, 26);
                Console.ForegroundColor = ConsoleColor.DarkBlue;  //PUERTA INFERIOR DERECHA (IZQUIERDA)
                Console.WriteLine("║");
                Console.SetCursorPosition(100, 24);
                Console.ForegroundColor = ConsoleColor.DarkBlue;  //PUERTA INFERIOR DERECHA (ARRIBA)
                Console.WriteLine("══");
                Console.SetCursorPosition(100, 15);
                Console.ForegroundColor = ConsoleColor.DarkYellow;  //PUERTA SUPERIOR DERECHA (ABAJO)
                Console.WriteLine("══");
                Console.SetCursorPosition(70, 24);
                Console.ForegroundColor = ConsoleColor.DarkYellow;   //PUERTA MEDIO ARRIBA
                Console.WriteLine("══");
                Console.SetCursorPosition(48, 24);
                Console.ForegroundColor = ConsoleColor.DarkYellow;   //PUERTA IZQUIERDA ARRIBA
                Console.WriteLine("══");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.SetCursorPosition(88, 8);       //CAJA FUERTE
                Console.WriteLine("╔═════╗");
                Console.SetCursorPosition(88, 9);
                Console.WriteLine("║╔═╦═╗║");
                Console.SetCursorPosition(88, 10);
                Console.WriteLine("║╠═O═╣║");
                Console.SetCursorPosition(88, 11);
                Console.WriteLine("║╚═╩═╝║");
                Console.SetCursorPosition(88, 12);
                Console.WriteLine("╚═════╝");
                Console.ForegroundColor = ConsoleColor.Gray;   //COMPUTADORAS
                Console.SetCursorPosition(67, 8);
                Console.WriteLine("╔══════╗");
                Console.SetCursorPosition(67, 9);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(67, 10);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(67, 11);
                Console.WriteLine("╚══╦╦══╝");
                Console.SetCursorPosition(67, 12);
                Console.WriteLine("╔╦╦╦╦╦╦╗");
                Console.SetCursorPosition(67, 13);
                Console.WriteLine("╚╩╩╩╩╩╩╝");
                Console.SetCursorPosition(46, 26);
                Console.WriteLine("╔══════╗");
                Console.SetCursorPosition(46, 27);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(46, 28);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(46, 29);
                Console.WriteLine("╚══╦╦══╝");
                Console.SetCursorPosition(46, 30);
                Console.WriteLine("╔╦╦╦╦╦╦╗");
                Console.SetCursorPosition(46, 31);
                Console.WriteLine("╚╩╩╩╩╩╩╝");
                Console.SetCursorPosition(46, 8);
                Console.WriteLine("╔══════╗");
                Console.SetCursorPosition(46, 9);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(46, 10);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(46, 11);
                Console.WriteLine("╚══╦╦══╝");
                Console.SetCursorPosition(46, 12);
                Console.WriteLine("╔╦╦╦╦╦╦╗");
                Console.SetCursorPosition(46, 13);
                Console.WriteLine("╚╩╩╩╩╩╩╝");
                Console.SetCursorPosition(46, 17);
                Console.WriteLine("╔══════╗");
                Console.SetCursorPosition(46, 18);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(46, 19);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(46, 20);
                Console.WriteLine("╚══╦╦══╝");
                Console.SetCursorPosition(46, 21);
                Console.WriteLine("╔╦╦╦╦╦╦╗");
                Console.SetCursorPosition(46, 22);
                Console.WriteLine("╚╩╩╩╩╩╩╝");
                Console.SetCursorPosition(67, 17);
                Console.WriteLine("╔══════╗");
                Console.SetCursorPosition(67, 18);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(67, 19);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(67, 20);
                Console.WriteLine("╚══╦╦══╝");
                Console.SetCursorPosition(67, 21);
                Console.WriteLine("╔╦╦╦╦╦╦╗");
                Console.SetCursorPosition(67, 22);
                Console.WriteLine("╚╩╩╩╩╩╩╝");
                Console.SetCursorPosition(88, 17);
                Console.WriteLine("╔══════╗");
                Console.SetCursorPosition(88, 18);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(88, 19);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(88, 20);
                Console.WriteLine("╚══╦╦══╝");
                Console.SetCursorPosition(88, 21);
                Console.WriteLine("╔╦╦╦╦╦╦╗");
                Console.SetCursorPosition(88, 22);
                Console.WriteLine("╚╩╩╩╩╩╩╝");
                Console.ResetColor();
                Console.SetCursorPosition(98, 19);
                Console.WriteLine(" n-n");
                Console.SetCursorPosition(98, 20);
                Console.WriteLine(" ┌|┐");
                Console.SetCursorPosition(98, 21);
                Console.WriteLine("  | ");
                Console.SetCursorPosition(98, 22);
                Console.WriteLine(" / \\");
                Thread.Sleep(5000);
            }
        }
        static void Mapa3_1()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            PANTALLA();
            INTERFAZ_2();
            {
                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 0; i <= 26; i++)      // vertical interior izquierda 
                {
                    Console.SetCursorPosition(65, (i + 7));
                    Console.WriteLine("█");
                }
                for (int i = 0; i <= 62; i++)
                {
                    Console.SetCursorPosition((i + 44), 15);
                    Console.WriteLine("█");
                }
                for (int i = 0; i <= 62; i++)
                {
                    Console.SetCursorPosition((i + 44), 24);
                    Console.WriteLine("█");
                }
                for (int i = 0; i <= 26; i++)  //vertical interior derecha
                {
                    Console.SetCursorPosition(86, (i + 7));
                    Console.WriteLine("█");
                }
                for (int i = 0; i <= 62; i++) //horizontal superior
                {
                    Console.SetCursorPosition((i + 44), 6);
                    Console.WriteLine("█");
                }
                for (int i = 0; i <= 26; i++) //vertical izquierda
                {
                    Console.SetCursorPosition(44, (i + 6));
                    Console.WriteLine("█");
                }
                for (int i = 0; i <= 62; i++) //horizontal inferior
                {
                    Console.SetCursorPosition((i + 44), 33);
                    Console.WriteLine("█");
                }
                for (int i = 0; i <= 26; i++)  //vertical derecha
                {
                    Console.SetCursorPosition(106, (i + 6));
                    Console.WriteLine("█");
                }
                //ELEMENTOS EN EL MAPA
                Console.ForegroundColor = ConsoleColor.DarkYellow;  //PUERTA ENTRADA PRINCIPAL
                Console.SetCursorPosition(52, 6);
                Console.WriteLine("═════");
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(50, 5);
                Console.WriteLine("█       █");
                Console.ForegroundColor = ConsoleColor.DarkBlue;  //PUERTA ENTRADA PRINCIPAL
                Console.SetCursorPosition(52, 33);
                Console.WriteLine("═════");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(50, 34);
                Console.WriteLine("█       █");
                Console.SetCursorPosition(50, 35);
                Console.WriteLine("█       █");
                Console.SetCursorPosition(65, 13);
                Console.ForegroundColor = ConsoleColor.DarkBlue;    //PUERTA SUPERIOR IZQUIERDA     
                Console.WriteLine("║");
                Console.SetCursorPosition(86, 13);
                Console.ForegroundColor = ConsoleColor.DarkBlue;  //PUERTA SUPERIOR CENTRO
                Console.WriteLine("║");
                Console.SetCursorPosition(65, 22);
                Console.ForegroundColor = ConsoleColor.DarkYellow;   //PUERTA MEDIA IZQUIERDA
                Console.WriteLine("║");
                Console.SetCursorPosition(86, 26);
                Console.ForegroundColor = ConsoleColor.DarkBlue;  //PUERTA INFERIOR DERECHA (IZQUIERDA)
                Console.WriteLine("║");
                Console.SetCursorPosition(100, 24);
                Console.ForegroundColor = ConsoleColor.DarkBlue;  //PUERTA INFERIOR DERECHA (ARRIBA)
                Console.WriteLine("══");
                Console.SetCursorPosition(100, 15);
                Console.ForegroundColor = ConsoleColor.DarkYellow;  //PUERTA SUPERIOR DERECHA (ABAJO)
                Console.WriteLine("══");
                Console.SetCursorPosition(70, 24);
                Console.ForegroundColor = ConsoleColor.DarkYellow;   //PUERTA MEDIO ARRIBA
                Console.WriteLine("══");
                Console.SetCursorPosition(48, 24);
                Console.ForegroundColor = ConsoleColor.DarkYellow;   //PUERTA IZQUIERDA ARRIBA
                Console.WriteLine("══");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.SetCursorPosition(88, 8);       //CAJA FUERTE
                Console.WriteLine("╔═════╗");
                Console.SetCursorPosition(88, 9);
                Console.WriteLine("║╔═╦═╗║");
                Console.SetCursorPosition(88, 10);
                Console.WriteLine("║╠═O═╣║");
                Console.SetCursorPosition(88, 11);
                Console.WriteLine("║╚═╩═╝║");
                Console.SetCursorPosition(88, 12);
                Console.WriteLine("╚═════╝");
                Console.ForegroundColor = ConsoleColor.Gray;   //COMPUTADORAS
                Console.SetCursorPosition(67, 8);
                Console.WriteLine("╔══════╗");
                Console.SetCursorPosition(67, 9);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(67, 10);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(67, 11);
                Console.WriteLine("╚══╦╦══╝");
                Console.SetCursorPosition(67, 12);
                Console.WriteLine("╔╦╦╦╦╦╦╗");
                Console.SetCursorPosition(67, 13);
                Console.WriteLine("╚╩╩╩╩╩╩╝");
                Console.SetCursorPosition(46, 26);
                Console.WriteLine("╔══════╗");
                Console.SetCursorPosition(46, 27);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(46, 28);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(46, 29);
                Console.WriteLine("╚══╦╦══╝");
                Console.SetCursorPosition(46, 30);
                Console.WriteLine("╔╦╦╦╦╦╦╗");
                Console.SetCursorPosition(46, 31);
                Console.WriteLine("╚╩╩╩╩╩╩╝");
                Console.SetCursorPosition(46, 8);
                Console.WriteLine("╔══════╗");
                Console.SetCursorPosition(46, 9);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(46, 10);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(46, 11);
                Console.WriteLine("╚══╦╦══╝");
                Console.SetCursorPosition(46, 12);
                Console.WriteLine("╔╦╦╦╦╦╦╗");
                Console.SetCursorPosition(46, 13);
                Console.WriteLine("╚╩╩╩╩╩╩╝");
                Console.SetCursorPosition(46, 17);
                Console.WriteLine("╔══════╗");
                Console.SetCursorPosition(46, 18);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(46, 19);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(46, 20);
                Console.WriteLine("╚══╦╦══╝");
                Console.SetCursorPosition(46, 21);
                Console.WriteLine("╔╦╦╦╦╦╦╗");
                Console.SetCursorPosition(46, 22);
                Console.WriteLine("╚╩╩╩╩╩╩╝");
                Console.SetCursorPosition(67, 17);
                Console.WriteLine("╔══════╗");
                Console.SetCursorPosition(67, 18);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(67, 19);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(67, 20);
                Console.WriteLine("╚══╦╦══╝");
                Console.SetCursorPosition(67, 21);
                Console.WriteLine("╔╦╦╦╦╦╦╗");
                Console.SetCursorPosition(67, 22);
                Console.WriteLine("╚╩╩╩╩╩╩╝");
                Console.SetCursorPosition(88, 17);
                Console.WriteLine("╔══════╗");
                Console.SetCursorPosition(88, 18);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(88, 19);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(88, 20);
                Console.WriteLine("╚══╦╦══╝");
                Console.SetCursorPosition(88, 21);
                Console.WriteLine("╔╦╦╦╦╦╦╗");
                Console.SetCursorPosition(88, 22);
                Console.WriteLine("╚╩╩╩╩╩╩╝");
                Console.ResetColor();
                Console.SetCursorPosition(58, 28);
                Console.WriteLine(" n-n");
                Console.SetCursorPosition(58, 29);
                Console.WriteLine(" ┌|┐");
                Console.SetCursorPosition(58, 30);
                Console.WriteLine("  | ");
                Console.SetCursorPosition(58, 31);
                Console.WriteLine(" / \\");
                Thread.Sleep(5000);
            }
        }
        static void Mapa3_2()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            PANTALLA();
            INTERFAZ_2();
            {
                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 0; i <= 26; i++)      // vertical interior izquierda 
                {
                    Console.SetCursorPosition(65, (i + 7));
                    Console.WriteLine("█");
                }
                for (int i = 0; i <= 62; i++)
                {
                    Console.SetCursorPosition((i + 44), 15);
                    Console.WriteLine("█");
                }
                for (int i = 0; i <= 62; i++)
                {
                    Console.SetCursorPosition((i + 44), 24);
                    Console.WriteLine("█");
                }
                for (int i = 0; i <= 26; i++)  //vertical interior derecha
                {
                    Console.SetCursorPosition(86, (i + 7));
                    Console.WriteLine("█");
                }
                for (int i = 0; i <= 62; i++) //horizontal superior
                {
                    Console.SetCursorPosition((i + 44), 6);
                    Console.WriteLine("█");
                }
                for (int i = 0; i <= 26; i++) //vertical izquierda
                {
                    Console.SetCursorPosition(44, (i + 6));
                    Console.WriteLine("█");
                }
                for (int i = 0; i <= 62; i++) //horizontal inferior
                {
                    Console.SetCursorPosition((i + 44), 33);
                    Console.WriteLine("█");
                }
                for (int i = 0; i <= 26; i++)  //vertical derecha
                {
                    Console.SetCursorPosition(106, (i + 6));
                    Console.WriteLine("█");
                }
                //ELEMENTOS EN EL MAPA
                Console.ForegroundColor = ConsoleColor.DarkYellow;  //PUERTA ENTRADA PRINCIPAL
                Console.SetCursorPosition(52, 6);
                Console.WriteLine("═════");
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(50, 5);
                Console.WriteLine("█       █");
                Console.ForegroundColor = ConsoleColor.DarkBlue;  //PUERTA ENTRADA PRINCIPAL
                Console.SetCursorPosition(52, 33);
                Console.WriteLine("═════");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(50, 34);
                Console.WriteLine("█       █");
                Console.SetCursorPosition(50, 35);
                Console.WriteLine("█       █");
                Console.SetCursorPosition(65, 13);
                Console.ForegroundColor = ConsoleColor.DarkBlue;    //PUERTA SUPERIOR IZQUIERDA     
                Console.WriteLine("║");
                Console.SetCursorPosition(86, 13);
                Console.ForegroundColor = ConsoleColor.DarkBlue;  //PUERTA SUPERIOR CENTRO
                Console.WriteLine("║");
                Console.SetCursorPosition(65, 22);
                Console.ForegroundColor = ConsoleColor.DarkYellow;   //PUERTA MEDIA IZQUIERDA
                Console.WriteLine("║");
                Console.SetCursorPosition(86, 26);
                Console.ForegroundColor = ConsoleColor.DarkBlue;  //PUERTA INFERIOR DERECHA (IZQUIERDA)
                Console.WriteLine("║");
                Console.SetCursorPosition(100, 24);
                Console.ForegroundColor = ConsoleColor.DarkBlue;  //PUERTA INFERIOR DERECHA (ARRIBA)
                Console.WriteLine("══");
                Console.SetCursorPosition(100, 15);
                Console.ForegroundColor = ConsoleColor.DarkYellow;  //PUERTA SUPERIOR DERECHA (ABAJO)
                Console.WriteLine("══");
                Console.SetCursorPosition(70, 24);
                Console.ForegroundColor = ConsoleColor.DarkYellow;   //PUERTA MEDIO ARRIBA
                Console.WriteLine("══");
                Console.SetCursorPosition(48, 24);
                Console.ForegroundColor = ConsoleColor.DarkYellow;   //PUERTA IZQUIERDA ARRIBA
                Console.WriteLine("══");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.SetCursorPosition(88, 8);       //CAJA FUERTE
                Console.WriteLine("╔═════╗");
                Console.SetCursorPosition(88, 9);
                Console.WriteLine("║╔═╦═╗║");
                Console.SetCursorPosition(88, 10);
                Console.WriteLine("║╠═O═╣║");
                Console.SetCursorPosition(88, 11);
                Console.WriteLine("║╚═╩═╝║");
                Console.SetCursorPosition(88, 12);
                Console.WriteLine("╚═════╝");
                Console.ForegroundColor = ConsoleColor.Gray;   //COMPUTADORAS
                Console.SetCursorPosition(67, 8);
                Console.WriteLine("╔══════╗");
                Console.SetCursorPosition(67, 9);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(67, 10);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(67, 11);
                Console.WriteLine("╚══╦╦══╝");
                Console.SetCursorPosition(67, 12);
                Console.WriteLine("╔╦╦╦╦╦╦╗");
                Console.SetCursorPosition(67, 13);
                Console.WriteLine("╚╩╩╩╩╩╩╝");
                Console.SetCursorPosition(46, 26);
                Console.WriteLine("╔══════╗");
                Console.SetCursorPosition(46, 27);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(46, 28);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(46, 29);
                Console.WriteLine("╚══╦╦══╝");
                Console.SetCursorPosition(46, 30);
                Console.WriteLine("╔╦╦╦╦╦╦╗");
                Console.SetCursorPosition(46, 31);
                Console.WriteLine("╚╩╩╩╩╩╩╝");
                Console.SetCursorPosition(46, 8);
                Console.WriteLine("╔══════╗");
                Console.SetCursorPosition(46, 9);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(46, 10);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(46, 11);
                Console.WriteLine("╚══╦╦══╝");
                Console.SetCursorPosition(46, 12);
                Console.WriteLine("╔╦╦╦╦╦╦╗");
                Console.SetCursorPosition(46, 13);
                Console.WriteLine("╚╩╩╩╩╩╩╝");
                Console.SetCursorPosition(46, 17);
                Console.WriteLine("╔══════╗");
                Console.SetCursorPosition(46, 18);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(46, 19);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(46, 20);
                Console.WriteLine("╚══╦╦══╝");
                Console.SetCursorPosition(46, 21);
                Console.WriteLine("╔╦╦╦╦╦╦╗");
                Console.SetCursorPosition(46, 22);
                Console.WriteLine("╚╩╩╩╩╩╩╝");
                Console.SetCursorPosition(67, 17);
                Console.WriteLine("╔══════╗");
                Console.SetCursorPosition(67, 18);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(67, 19);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(67, 20);
                Console.WriteLine("╚══╦╦══╝");
                Console.SetCursorPosition(67, 21);
                Console.WriteLine("╔╦╦╦╦╦╦╗");
                Console.SetCursorPosition(67, 22);
                Console.WriteLine("╚╩╩╩╩╩╩╝");
                Console.SetCursorPosition(88, 17);
                Console.WriteLine("╔══════╗");
                Console.SetCursorPosition(88, 18);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(88, 19);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(88, 20);
                Console.WriteLine("╚══╦╦══╝");
                Console.SetCursorPosition(88, 21);
                Console.WriteLine("╔╦╦╦╦╦╦╗");
                Console.SetCursorPosition(88, 22);
                Console.WriteLine("╚╩╩╩╩╩╩╝");
                Console.ResetColor();
                Console.SetCursorPosition(78, 28);
                Console.WriteLine(" n-n");
                Console.SetCursorPosition(78, 29);
                Console.WriteLine(" ┌|┐");
                Console.SetCursorPosition(78, 30);
                Console.WriteLine("  | ");
                Console.SetCursorPosition(78, 31);
                Console.WriteLine(" / \\");
                Thread.Sleep(5000);
            }
        }
        static void Mapa3_3()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            PANTALLA();
            INTERFAZ_2();
            {
                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 0; i <= 26; i++)      // vertical interior izquierda 
                {
                    Console.SetCursorPosition(65, (i + 7));
                    Console.WriteLine("█");
                }
                for (int i = 0; i <= 62; i++)
                {
                    Console.SetCursorPosition((i + 44), 15);
                    Console.WriteLine("█");
                }
                for (int i = 0; i <= 62; i++)
                {
                    Console.SetCursorPosition((i + 44), 24);
                    Console.WriteLine("█");
                }
                for (int i = 0; i <= 26; i++)  //vertical interior derecha
                {
                    Console.SetCursorPosition(86, (i + 7));
                    Console.WriteLine("█");
                }
                for (int i = 0; i <= 62; i++) //horizontal superior
                {
                    Console.SetCursorPosition((i + 44), 6);
                    Console.WriteLine("█");
                }
                for (int i = 0; i <= 26; i++) //vertical izquierda
                {
                    Console.SetCursorPosition(44, (i + 6));
                    Console.WriteLine("█");
                }
                for (int i = 0; i <= 62; i++) //horizontal inferior
                {
                    Console.SetCursorPosition((i + 44), 33);
                    Console.WriteLine("█");
                }
                for (int i = 0; i <= 26; i++)  //vertical derecha
                {
                    Console.SetCursorPosition(106, (i + 6));
                    Console.WriteLine("█");
                }
                //ELEMENTOS EN EL MAPA
                Console.ForegroundColor = ConsoleColor.DarkYellow;  //PUERTA ENTRADA PRINCIPAL
                Console.SetCursorPosition(52, 6);
                Console.WriteLine("═════");
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(50, 5);
                Console.WriteLine("█       █");
                Console.ForegroundColor = ConsoleColor.DarkBlue;  //PUERTA ENTRADA PRINCIPAL
                Console.SetCursorPosition(52, 33);
                Console.WriteLine("═════");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(50, 34);
                Console.WriteLine("█       █");
                Console.SetCursorPosition(50, 35);
                Console.WriteLine("█       █");
                Console.SetCursorPosition(65, 13);
                Console.ForegroundColor = ConsoleColor.DarkBlue;    //PUERTA SUPERIOR IZQUIERDA     
                Console.WriteLine("║");
                Console.SetCursorPosition(86, 13);
                Console.ForegroundColor = ConsoleColor.DarkBlue;  //PUERTA SUPERIOR CENTRO
                Console.WriteLine("║");
                Console.SetCursorPosition(65, 22);
                Console.ForegroundColor = ConsoleColor.DarkYellow;   //PUERTA MEDIA IZQUIERDA
                Console.WriteLine("║");
                Console.SetCursorPosition(86, 26);
                Console.ForegroundColor = ConsoleColor.DarkBlue;  //PUERTA INFERIOR DERECHA (IZQUIERDA)
                Console.WriteLine("║");
                Console.SetCursorPosition(100, 24);
                Console.ForegroundColor = ConsoleColor.DarkBlue;  //PUERTA INFERIOR DERECHA (ARRIBA)
                Console.WriteLine("══");
                Console.SetCursorPosition(100, 15);
                Console.ForegroundColor = ConsoleColor.DarkYellow;  //PUERTA SUPERIOR DERECHA (ABAJO)
                Console.WriteLine("══");
                Console.SetCursorPosition(70, 24);
                Console.ForegroundColor = ConsoleColor.DarkYellow;   //PUERTA MEDIO ARRIBA
                Console.WriteLine("══");
                Console.SetCursorPosition(48, 24);
                Console.ForegroundColor = ConsoleColor.DarkYellow;   //PUERTA IZQUIERDA ARRIBA
                Console.WriteLine("══");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.SetCursorPosition(88, 8);       //CAJA FUERTE
                Console.WriteLine("╔═════╗");
                Console.SetCursorPosition(88, 9);
                Console.WriteLine("║╔═╦═╗║");
                Console.SetCursorPosition(88, 10);
                Console.WriteLine("║╠═O═╣║");
                Console.SetCursorPosition(88, 11);
                Console.WriteLine("║╚═╩═╝║");
                Console.SetCursorPosition(88, 12);
                Console.WriteLine("╚═════╝");
                Console.ForegroundColor = ConsoleColor.Gray;   //COMPUTADORAS
                Console.SetCursorPosition(67, 8);
                Console.WriteLine("╔══════╗");
                Console.SetCursorPosition(67, 9);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(67, 10);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(67, 11);
                Console.WriteLine("╚══╦╦══╝");
                Console.SetCursorPosition(67, 12);
                Console.WriteLine("╔╦╦╦╦╦╦╗");
                Console.SetCursorPosition(67, 13);
                Console.WriteLine("╚╩╩╩╩╩╩╝");
                Console.SetCursorPosition(46, 26);
                Console.WriteLine("╔══════╗");
                Console.SetCursorPosition(46, 27);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(46, 28);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(46, 29);
                Console.WriteLine("╚══╦╦══╝");
                Console.SetCursorPosition(46, 30);
                Console.WriteLine("╔╦╦╦╦╦╦╗");
                Console.SetCursorPosition(46, 31);
                Console.WriteLine("╚╩╩╩╩╩╩╝");
                Console.SetCursorPosition(46, 8);
                Console.WriteLine("╔══════╗");
                Console.SetCursorPosition(46, 9);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(46, 10);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(46, 11);
                Console.WriteLine("╚══╦╦══╝");
                Console.SetCursorPosition(46, 12);
                Console.WriteLine("╔╦╦╦╦╦╦╗");
                Console.SetCursorPosition(46, 13);
                Console.WriteLine("╚╩╩╩╩╩╩╝");
                Console.SetCursorPosition(46, 17);
                Console.WriteLine("╔══════╗");
                Console.SetCursorPosition(46, 18);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(46, 19);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(46, 20);
                Console.WriteLine("╚══╦╦══╝");
                Console.SetCursorPosition(46, 21);
                Console.WriteLine("╔╦╦╦╦╦╦╗");
                Console.SetCursorPosition(46, 22);
                Console.WriteLine("╚╩╩╩╩╩╩╝");
                Console.SetCursorPosition(67, 17);
                Console.WriteLine("╔══════╗");
                Console.SetCursorPosition(67, 18);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(67, 19);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(67, 20);
                Console.WriteLine("╚══╦╦══╝");
                Console.SetCursorPosition(67, 21);
                Console.WriteLine("╔╦╦╦╦╦╦╗");
                Console.SetCursorPosition(67, 22);
                Console.WriteLine("╚╩╩╩╩╩╩╝");
                Console.SetCursorPosition(88, 17);
                Console.WriteLine("╔══════╗");
                Console.SetCursorPosition(88, 18);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(88, 19);
                Console.WriteLine("║      ║");
                Console.SetCursorPosition(88, 20);
                Console.WriteLine("╚══╦╦══╝");
                Console.SetCursorPosition(88, 21);
                Console.WriteLine("╔╦╦╦╦╦╦╗");
                Console.SetCursorPosition(88, 22);
                Console.WriteLine("╚╩╩╩╩╩╩╝");
                Console.ResetColor();
                Console.SetCursorPosition(98, 28);
                Console.WriteLine(" n-n");
                Console.SetCursorPosition(98, 29);
                Console.WriteLine(" ┌|┐");
                Console.SetCursorPosition(98, 30);
                Console.WriteLine("  | ");
                Console.SetCursorPosition(98, 31);
                Console.WriteLine(" / \\");
                Thread.Sleep(5000);
            }
        }
        static void MAPA_CORTO()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            PANTALLA();
            INTERFAZ_2();
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i <= 26; i++)      // vertical interior izquierda 
            {
                Console.SetCursorPosition(65, (i + 7));
                Console.WriteLine("█");
            }
            for (int i = 0; i <= 62; i++)
            {
                Console.SetCursorPosition((i + 44), 15);
                Console.WriteLine("█");
            }
            for (int i = 0; i <= 62; i++)
            {
                Console.SetCursorPosition((i + 44), 24);
                Console.WriteLine("█");
            }
            for (int i = 0; i <= 26; i++)  //vertical interior derecha
            {
                Console.SetCursorPosition(86, (i + 7));
                Console.WriteLine("█");
            }
            for (int i = 0; i <= 62; i++) //horizontal superior
            {
                Console.SetCursorPosition((i + 44), 6);
                Console.WriteLine("█");
            }
            for (int i = 0; i <= 26; i++) //vertical izquierda
            {
                Console.SetCursorPosition(44, (i + 6));
                Console.WriteLine("█");
            }
            for (int i = 0; i <= 62; i++) //horizontal inferior
            {
                Console.SetCursorPosition((i + 44), 33);
                Console.WriteLine("█");
            }
            for (int i = 0; i <= 26; i++)  //vertical derecha
            {
                Console.SetCursorPosition(106, (i + 6));
                Console.WriteLine("█");
            }
            //ELEMENTOS EN EL MAPA
            Console.ForegroundColor = ConsoleColor.DarkYellow;  //PUERTA ENTRADA PRINCIPAL
            Console.SetCursorPosition(52, 6);
            Console.WriteLine("═════");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(50, 5);
            Console.WriteLine("█       █");
            Console.ForegroundColor = ConsoleColor.DarkBlue;  //PUERTA ENTRADA PRINCIPAL
            Console.SetCursorPosition(52, 33);
            Console.WriteLine("═════");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(50, 34);
            Console.WriteLine("█       █");
            Console.SetCursorPosition(50, 35);
            Console.WriteLine("█       █");
            Console.SetCursorPosition(65, 13);
            Console.ForegroundColor = ConsoleColor.DarkBlue;    //PUERTA SUPERIOR IZQUIERDA     
            Console.WriteLine("║");
            Console.SetCursorPosition(86, 13);
            Console.ForegroundColor = ConsoleColor.DarkBlue;  //PUERTA SUPERIOR CENTRO
            Console.WriteLine("║");
            Console.SetCursorPosition(65, 22);
            Console.ForegroundColor = ConsoleColor.DarkYellow;   //PUERTA MEDIA IZQUIERDA
            Console.WriteLine("║");
            Console.SetCursorPosition(86, 26);
            Console.ForegroundColor = ConsoleColor.DarkBlue;  //PUERTA INFERIOR DERECHA (IZQUIERDA)
            Console.WriteLine("║");
            Console.SetCursorPosition(100, 24);
            Console.ForegroundColor = ConsoleColor.DarkBlue;  //PUERTA INFERIOR DERECHA (ARRIBA)
            Console.WriteLine("══");
            Console.SetCursorPosition(100, 15);
            Console.ForegroundColor = ConsoleColor.DarkYellow;  //PUERTA SUPERIOR DERECHA (ABAJO)
            Console.WriteLine("══");
            Console.SetCursorPosition(70, 24);
            Console.ForegroundColor = ConsoleColor.DarkYellow;   //PUERTA MEDIO ARRIBA
            Console.WriteLine("══");
            Console.SetCursorPosition(48, 24);
            Console.ForegroundColor = ConsoleColor.DarkYellow;   //PUERTA IZQUIERDA ARRIBA
            Console.WriteLine("══");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(88, 8);       //CAJA FUERTE
            Console.WriteLine("╔═════╗");
            Console.SetCursorPosition(88, 9);
            Console.WriteLine("║╔═╦═╗║");
            Console.SetCursorPosition(88, 10);
            Console.WriteLine("║╠═O═╣║");
            Console.SetCursorPosition(88, 11);
            Console.WriteLine("║╚═╩═╝║");
            Console.SetCursorPosition(88, 12);
            Console.WriteLine("╚═════╝");
            Console.ForegroundColor = ConsoleColor.Gray;   //COMPUTADORAS
            Console.SetCursorPosition(67, 8);
            Console.WriteLine("╔══════╗");
            Console.SetCursorPosition(67, 9);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(67, 10);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(67, 11);
            Console.WriteLine("╚══╦╦══╝");
            Console.SetCursorPosition(67, 12);
            Console.WriteLine("╔╦╦╦╦╦╦╗");
            Console.SetCursorPosition(67, 13);
            Console.WriteLine("╚╩╩╩╩╩╩╝");
            Console.SetCursorPosition(46, 26);
            Console.WriteLine("╔══════╗");
            Console.SetCursorPosition(46, 27);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(46, 28);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(46, 29);
            Console.WriteLine("╚══╦╦══╝");
            Console.SetCursorPosition(46, 30);
            Console.WriteLine("╔╦╦╦╦╦╦╗");
            Console.SetCursorPosition(46, 31);
            Console.WriteLine("╚╩╩╩╩╩╩╝");
            Console.SetCursorPosition(46, 8);
            Console.WriteLine("╔══════╗");
            Console.SetCursorPosition(46, 9);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(46, 10);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(46, 11);
            Console.WriteLine("╚══╦╦══╝");
            Console.SetCursorPosition(46, 12);
            Console.WriteLine("╔╦╦╦╦╦╦╗");
            Console.SetCursorPosition(46, 13);
            Console.WriteLine("╚╩╩╩╩╩╩╝");
            Console.SetCursorPosition(46, 17);
            Console.WriteLine("╔══════╗");
            Console.SetCursorPosition(46, 18);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(46, 19);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(46, 20);
            Console.WriteLine("╚══╦╦══╝");
            Console.SetCursorPosition(46, 21);
            Console.WriteLine("╔╦╦╦╦╦╦╗");
            Console.SetCursorPosition(46, 22);
            Console.WriteLine("╚╩╩╩╩╩╩╝");
            Console.SetCursorPosition(67, 17);
            Console.WriteLine("╔══════╗");
            Console.SetCursorPosition(67, 18);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(67, 19);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(67, 20);
            Console.WriteLine("╚══╦╦══╝");
            Console.SetCursorPosition(67, 21);
            Console.WriteLine("╔╦╦╦╦╦╦╗");
            Console.SetCursorPosition(67, 22);
            Console.WriteLine("╚╩╩╩╩╩╩╝");
            Console.SetCursorPosition(88, 17);
            Console.WriteLine("╔══════╗");
            Console.SetCursorPosition(88, 18);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(88, 19);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(88, 20);
            Console.WriteLine("╚══╦╦══╝");
            Console.SetCursorPosition(88, 21);
            Console.WriteLine("╔╦╦╦╦╦╦╗");
            Console.SetCursorPosition(88, 22);
            Console.WriteLine("╚╩╩╩╩╩╩╝");
            Console.ResetColor();
            Console.SetCursorPosition(35, 5);
            Console.WriteLine(" n-n");
            Console.SetCursorPosition(35, 6);
            Console.WriteLine(" ┌|┐");
            Console.SetCursorPosition(35, 7);
            Console.WriteLine("  | ");
            Console.SetCursorPosition(35, 8);
            Console.WriteLine(" / \\");
            Console.ReadLine();
        }
        static void MAPA_LARGO()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            PANTALLA();
            INTERFAZ_2();
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i <= 26; i++)      // vertical interior izquierda 
            {
                Console.SetCursorPosition(65, (i + 7));
                Console.WriteLine("█");
            }
            for (int i = 0; i <= 62; i++)
            {
                Console.SetCursorPosition((i + 44), 15);
                Console.WriteLine("█");
            }
            for (int i = 0; i <= 62; i++)
            {
                Console.SetCursorPosition((i + 44), 24);
                Console.WriteLine("█");
            }
            for (int i = 0; i <= 26; i++)  //vertical interior derecha
            {
                Console.SetCursorPosition(86, (i + 7));
                Console.WriteLine("█");
            }
            for (int i = 0; i <= 62; i++) //horizontal superior
            {
                Console.SetCursorPosition((i + 44), 6);
                Console.WriteLine("█");
            }
            for (int i = 0; i <= 26; i++) //vertical izquierda
            {
                Console.SetCursorPosition(44, (i + 6));
                Console.WriteLine("█");
            }
            for (int i = 0; i <= 62; i++) //horizontal inferior
            {
                Console.SetCursorPosition((i + 44), 33);
                Console.WriteLine("█");
            }
            for (int i = 0; i <= 26; i++)  //vertical derecha
            {
                Console.SetCursorPosition(106, (i + 6));
                Console.WriteLine("█");
            }
            //ELEMENTOS EN EL MAPA
            Console.ForegroundColor = ConsoleColor.DarkYellow;  //PUERTA ENTRADA PRINCIPAL
            Console.SetCursorPosition(52, 6);
            Console.WriteLine("═════");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(50, 5);
            Console.WriteLine("█       █");
            Console.ForegroundColor = ConsoleColor.DarkBlue;  //PUERTA ENTRADA PRINCIPAL
            Console.SetCursorPosition(52, 33);
            Console.WriteLine("═════");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(50, 34);
            Console.WriteLine("█       █");
            Console.SetCursorPosition(50, 35);
            Console.WriteLine("█       █");
            Console.SetCursorPosition(65, 13);
            Console.ForegroundColor = ConsoleColor.DarkBlue;    //PUERTA SUPERIOR IZQUIERDA     
            Console.WriteLine("║");
            Console.SetCursorPosition(86, 13);
            Console.ForegroundColor = ConsoleColor.DarkBlue;  //PUERTA SUPERIOR CENTRO
            Console.WriteLine("║");
            Console.SetCursorPosition(65, 22);
            Console.ForegroundColor = ConsoleColor.DarkYellow;   //PUERTA MEDIA IZQUIERDA
            Console.WriteLine("║");
            Console.SetCursorPosition(86, 26);
            Console.ForegroundColor = ConsoleColor.DarkBlue;  //PUERTA INFERIOR DERECHA (IZQUIERDA)
            Console.WriteLine("║");
            Console.SetCursorPosition(100, 24);
            Console.ForegroundColor = ConsoleColor.DarkBlue;  //PUERTA INFERIOR DERECHA (ARRIBA)
            Console.WriteLine("══");
            Console.SetCursorPosition(100, 15);
            Console.ForegroundColor = ConsoleColor.DarkYellow;  //PUERTA SUPERIOR DERECHA (ABAJO)
            Console.WriteLine("══");
            Console.SetCursorPosition(70, 24);
            Console.ForegroundColor = ConsoleColor.DarkYellow;   //PUERTA MEDIO ARRIBA
            Console.WriteLine("══");
            Console.SetCursorPosition(48, 24);
            Console.ForegroundColor = ConsoleColor.DarkYellow;   //PUERTA IZQUIERDA ARRIBA
            Console.WriteLine("══");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(88, 8);       //CAJA FUERTE
            Console.WriteLine("╔═════╗");
            Console.SetCursorPosition(88, 9);
            Console.WriteLine("║╔═╦═╗║");
            Console.SetCursorPosition(88, 10);
            Console.WriteLine("║╠═O═╣║");
            Console.SetCursorPosition(88, 11);
            Console.WriteLine("║╚═╩═╝║");
            Console.SetCursorPosition(88, 12);
            Console.WriteLine("╚═════╝");
            Console.ForegroundColor = ConsoleColor.Gray;   //COMPUTADORAS
            Console.SetCursorPosition(67, 8);
            Console.WriteLine("╔══════╗");
            Console.SetCursorPosition(67, 9);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(67, 10);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(67, 11);
            Console.WriteLine("╚══╦╦══╝");
            Console.SetCursorPosition(67, 12);
            Console.WriteLine("╔╦╦╦╦╦╦╗");
            Console.SetCursorPosition(67, 13);
            Console.WriteLine("╚╩╩╩╩╩╩╝");
            Console.SetCursorPosition(46, 26);
            Console.WriteLine("╔══════╗");
            Console.SetCursorPosition(46, 27);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(46, 28);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(46, 29);
            Console.WriteLine("╚══╦╦══╝");
            Console.SetCursorPosition(46, 30);
            Console.WriteLine("╔╦╦╦╦╦╦╗");
            Console.SetCursorPosition(46, 31);
            Console.WriteLine("╚╩╩╩╩╩╩╝");
            Console.SetCursorPosition(46, 8);
            Console.WriteLine("╔══════╗");
            Console.SetCursorPosition(46, 9);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(46, 10);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(46, 11);
            Console.WriteLine("╚══╦╦══╝");
            Console.SetCursorPosition(46, 12);
            Console.WriteLine("╔╦╦╦╦╦╦╗");
            Console.SetCursorPosition(46, 13);
            Console.WriteLine("╚╩╩╩╩╩╩╝");
            Console.SetCursorPosition(46, 17);
            Console.WriteLine("╔══════╗");
            Console.SetCursorPosition(46, 18);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(46, 19);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(46, 20);
            Console.WriteLine("╚══╦╦══╝");
            Console.SetCursorPosition(46, 21);
            Console.WriteLine("╔╦╦╦╦╦╦╗");
            Console.SetCursorPosition(46, 22);
            Console.WriteLine("╚╩╩╩╩╩╩╝");
            Console.SetCursorPosition(67, 17);
            Console.WriteLine("╔══════╗");
            Console.SetCursorPosition(67, 18);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(67, 19);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(67, 20);
            Console.WriteLine("╚══╦╦══╝");
            Console.SetCursorPosition(67, 21);
            Console.WriteLine("╔╦╦╦╦╦╦╗");
            Console.SetCursorPosition(67, 22);
            Console.WriteLine("╚╩╩╩╩╩╩╝");
            Console.SetCursorPosition(88, 17);
            Console.WriteLine("╔══════╗");
            Console.SetCursorPosition(88, 18);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(88, 19);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(88, 20);
            Console.WriteLine("╚══╦╦══╝");
            Console.SetCursorPosition(88, 21);
            Console.WriteLine("╔╦╦╦╦╦╦╗");
            Console.SetCursorPosition(88, 22);
            Console.WriteLine("╚╩╩╩╩╩╩╝");
            Console.ResetColor();
            Console.SetCursorPosition(35, 33);
            Console.WriteLine(" n-n");
            Console.SetCursorPosition(35, 34);
            Console.WriteLine(" ┌|┐");
            Console.SetCursorPosition(35, 35);
            Console.WriteLine("  | ");
            Console.SetCursorPosition(35, 36);
            Console.WriteLine(" / \\");
            Console.ReadLine();
        }
        static void CONVERSACION_INTRO()
        {
            int y = 0;
            int AVANCE = 3;
            int longitud;
            char L;
            Console.CursorVisible = false;

            string C1 = "AGENTE SNAKE:   -Ya llegué";
            longitud = C1.Length;
            for (int i = 0; i <= 25; i++)
            {
                Console.SetCursorPosition((i + 4), AVANCE);
                Thread.Sleep(40);
                L = C1[i];
                Console.Write(L);
            }
            AVANCE = AVANCE + 1;
            string C2 = "Dame   las   instrucciones";
            longitud = C2.Length;
            for (int i = 0; i <= 25; i++)
            {
                Console.SetCursorPosition((i + 4), AVANCE);
                Thread.Sleep(40);
                L = C2[i];
                Console.Write(L);
            }
            AVANCE = AVANCE + 1;
            string C3 = "para robar  los planos se-";
            longitud = C3.Length;
            for (int i = 0; i <= 25; i++)
            {
                Console.SetCursorPosition((i + 4), AVANCE);
                Thread.Sleep(40);
                L = C3[i];
                Console.Write(L);
            }
            AVANCE = AVANCE + 1;
            string C4 = "cretos-.                  ";
            longitud = C4.Length;
            for (int i = 0; i <= 25; i++)
            {
                Console.SetCursorPosition((i + 4), AVANCE);
                Thread.Sleep(40);
                L = C4[i];
                Console.Write(L);
            }
            AVANCE = AVANCE + 1;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            string C5 = "ATLAS: -Muy  bien  agente.";
            longitud = C5.Length;
            for (int i = 0; i <= 25; i++)
            {
                Console.SetCursorPosition((i + 4), AVANCE);
                Thread.Sleep(40);
                L = C5[i];
                Console.Write(L);
            }
            AVANCE = AVANCE + 1;
            string C6 = "Tienes  dos  caminos  para";
            longitud = C6.Length;
            for (int i = 0; i <= 25; i++)
            {
                Console.SetCursorPosition((i + 4), AVANCE);
                Thread.Sleep(40);
                L = C6[i];
                Console.Write(L);
            }
            AVANCE = AVANCE + 1;
            string C7 = "robar los planos secretos.";
            longitud = C7.Length;
            for (int i = 0; i <= 25; i++)
            {
                Console.SetCursorPosition((i + 4), AVANCE);
                Thread.Sleep(40);
                L = C7[i];
                Console.Write(L);
            }
            AVANCE = AVANCE + 1;
            string C8 = "La  entrada  delantera  es";
            longitud = C8.Length;
            for (int i = 0; i <= 25; i++)
            {
                Console.SetCursorPosition((i + 4), AVANCE);
                Thread.Sleep(40);
                L = C8[i];
                Console.Write(L);
            }
            AVANCE = AVANCE + 1;
            string C9 = "fácil, y  la trasera difi-";
            longitud = C9.Length;
            for (int i = 0; i <= 25; i++)
            {
                Console.SetCursorPosition((i + 4), AVANCE);
                Thread.Sleep(40);
                L = C9[i];
                Console.Write(L);
            }
            AVANCE = AVANCE + 1;
            string C10 = "cil. ¿Cuál eliges?        ";
            longitud = C10.Length;
            for (int i = 0; i <= 25; i++)
            {
                Console.SetCursorPosition((i + 4), AVANCE);
                Thread.Sleep(40);
                L = C10[i];
                Console.Write(L);
            }
            AVANCE = AVANCE + 1;
            Console.ResetColor();


            Console.CursorVisible = true;
        }
        static void CONVERSACION_CAMINO_CORTO()
        {
            int y = 0;
            int AVANCE = 3;
            int longitud;
            char L;
            Console.CursorVisible = false;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            string C1 = "ATLAS: -Bien agente Snake.";
            longitud = C1.Length;
            for (int i = 0; i <= 25; i++)
            {
                Console.SetCursorPosition((i + 4), AVANCE);
                Thread.Sleep(40);
                L = C1[i];
                Console.Write(L);
            }
            AVANCE = AVANCE + 1;
            string C2 = "El camino  es  corto, sólo";
            longitud = C2.Length;
            for (int i = 0; i <= 25; i++)
            {
                Console.SetCursorPosition((i + 4), AVANCE);
                Thread.Sleep(40);
                L = C2[i];
                Console.Write(L);
            }
            AVANCE = AVANCE + 1;
            string C3 = "tienes  que atravesar  dos";
            longitud = C3.Length;
            for (int i = 0; i <= 25; i++)
            {
                Console.SetCursorPosition((i + 4), AVANCE);
                Thread.Sleep(40);
                L = C3[i];
                Console.Write(L);
            }
            AVANCE = AVANCE + 1;
            string C4 = "habitaciones  para   robar";
            longitud = C4.Length;
            for (int i = 0; i <= 25; i++)
            {
                Console.SetCursorPosition((i + 4), AVANCE);
                Thread.Sleep(40);
                L = C4[i];
                Console.Write(L);
            }
            AVANCE = AVANCE + 1;
            string C5 = "los planos.  Pero los sis-";
            longitud = C5.Length;
            for (int i = 0; i <= 25; i++)
            {
                Console.SetCursorPosition((i + 4), AVANCE);
                Thread.Sleep(40);
                L = C5[i];
                Console.Write(L);
            }
            AVANCE = AVANCE + 1;
            string C6 = "temas de seguridad son muy";
            longitud = C6.Length;
            for (int i = 0; i <= 25; i++)
            {
                Console.SetCursorPosition((i + 4), AVANCE);
                Thread.Sleep(40);
                L = C6[i];
                Console.Write(L);
            }
            AVANCE = AVANCE + 1;
            string C7 = "difíciles.                ";
            longitud = C7.Length;
            for (int i = 0; i <= 25; i++)
            {
                Console.SetCursorPosition((i + 4), AVANCE);
                Thread.Sleep(40);
                L = C7[i];
                Console.Write(L);
            }
            AVANCE = AVANCE + 2;
            string C8 = "Buena suerte. ATLAS fuera.";
            longitud = C8.Length;
            for (int i = 0; i <= 25; i++)
            {
                Console.SetCursorPosition((i + 4), AVANCE);
                Thread.Sleep(40);
                L = C8[i];
                Console.Write(L);
            }

            Thread.Sleep(5000);
        }
        static void CONVERSACION_CAMINO_LARGO()
        {
            int y = 0;
            int AVANCE = 3;
            int longitud;
            char L;
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            string C1 = "ATLAS: -Lento pero seguro.";
            longitud = C1.Length;
            for (int i = 0; i <= 25; i++)
            {
                Console.SetCursorPosition((i + 4), AVANCE);
                Thread.Sleep(40);
                L = C1[i];
                Console.Write(L);
            }
            AVANCE = AVANCE + 1;
            string C2 = "Consigue   la   contraseña ";
            longitud = C2.Length;
            for (int i = 0; i <= 25; i++)
            {
                Console.SetCursorPosition((i + 4), AVANCE);
                Thread.Sleep(40);
                L = C2[i];
                Console.Write(L);
            }
            AVANCE = AVANCE + 1;
            string C3 = "de  la   puerta  principal";
            longitud = C3.Length;
            for (int i = 0; i <= 25; i++)
            {
                Console.SetCursorPosition((i + 4), AVANCE);
                Thread.Sleep(40);
                L = C3[i];
                Console.Write(L);
            }
            Console.ForegroundColor = ConsoleColor.White;
            AVANCE = AVANCE + 2;
            string C4 = "SNAKE:   -Entendido  ATLAS";
            longitud = C4.Length;
            for (int i = 0; i <= 25; i++)
            {
                Console.SetCursorPosition((i + 4), AVANCE);
                Thread.Sleep(40);
                L = C4[i];
                Console.Write(L);
            }
            Console.ForegroundColor = ConsoleColor.DarkGray;
            AVANCE = AVANCE + 2;
            string C5 = "ATLAS: -Al  entrar tendras";
            longitud = C5.Length;
            for (int i = 0; i <= 25; i++)
            {
                Console.SetCursorPosition((i + 4), AVANCE);
                Thread.Sleep(40);
                L = C5[i];
                Console.Write(L);
            }
            AVANCE = AVANCE + 1;
            string C6 = "que pasar  por  6 cuartos,";
            longitud = C6.Length;
            for (int i = 0; i <= 25; i++)
            {
                Console.SetCursorPosition((i + 4), AVANCE);
                Thread.Sleep(40);
                L = C6[i];
                Console.Write(L);
            }
            AVANCE = AVANCE + 1;
            string C7 = "en el camino   encontrarás";
            longitud = C7.Length;
            for (int i = 0; i <= 25; i++)
            {
                Console.SetCursorPosition((i + 4), AVANCE);
                Thread.Sleep(40);
                L = C7[i];
                Console.Write(L);
            }
            AVANCE = AVANCE + 1;
            string C8 = "una  serie  de ordenadores";
            longitud = C8.Length;
            for (int i = 0; i <= 25; i++)
            {
                Console.SetCursorPosition((i + 4), AVANCE);
                Thread.Sleep(40);
                L = C8[i];
                Console.Write(L);
            }
            AVANCE = AVANCE + 1;
            string C9 = "y   algunas  puertas  para";
            longitud = C9.Length;
            for (int i = 0; i <= 25; i++)
            {
                Console.SetCursorPosition((i + 4), AVANCE);
                Thread.Sleep(40);
                L = C9[i];
                Console.Write(L);
            }
            AVANCE = AVANCE + 1;
            string C10 = "forzar  o  hackear,  buena";
            longitud = C10.Length;
            for (int i = 0; i <= 25; i++)
            {
                Console.SetCursorPosition((i + 4), AVANCE);
                Thread.Sleep(40);
                L = C10[i];
                Console.Write(L);
            }
            AVANCE = AVANCE + 1;
            string C11 = "buena suerte, atlas fuera.";
            longitud = C11.Length;
            for (int i = 0; i <= 25; i++)
            {
                Console.SetCursorPosition((i + 4), AVANCE);
                Thread.Sleep(40);
                L = C11[i];
                Console.Write(L);
            }
            Thread.Sleep(5000);
        }

        static void MENU()
        {
            PANTALLA();
            INTERFAZ();
            BIENVENIDO();

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(4, 2);
            Thread.Sleep(500);
            Console.WriteLine("1. JUGAR");
            Console.SetCursorPosition(4, 4);
            Thread.Sleep(500);
            Console.WriteLine("2. SALIR");
            Console.SetCursorPosition(4, 6);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            CARGANDO();
            Console.ReadKey();
        }                    //MENU
        static void JUEGO_4()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            PANTALLA();
            INTERFAZ_2();
            int x = 0;
            Random ran = new Random();
            Random ran2 = new Random();
            ran.Next(10);
            List<int> voltios = new List<int>();
            voltios.Add(25);
            voltios.Add(10);
            voltios.Add(15);
            voltios.Add(20);
            voltios.Add(30);
            int b;
            int g;
            int y;
            int r;
            int m;
            ran2.Next(voltios.Count);
            b = ran2.Next(0, voltios.Count);
            b = voltios[b];
            voltios.Remove(b);
            g = ran2.Next(0, voltios.Count);
            g = voltios[g];
            voltios.Remove(g);
            y = ran2.Next(0, voltios.Count);
            y = voltios[y];
            voltios.Remove(y);
            r = ran2.Next(0, voltios.Count);
            r = voltios[r];
            voltios.Remove(r);
            m = ran2.Next(0, voltios.Count);
            m = voltios[m];
            voltios.Remove(m);
            x = ran.Next(1, 5);
            switch (x)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                default:
                    break;
            }
            Console.SetCursorPosition(33, 13);

            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.SetCursorPosition(97, 12);
            Console.WriteLine("╔══════╗");
            Console.SetCursorPosition(97, 13);
            Console.WriteLine("║  " + "██" + "  ║ (Cable 1)");
            Console.SetCursorPosition(97, 14);
            Console.WriteLine("╚══════╝");
            Console.WriteLine();
            x = 0;
            x = ran.Next(1, 5);
            switch (x)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                default:
                    Console.WriteLine("PENEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE");
                    break;
            }
            Console.SetCursorPosition(33, 16);

            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.SetCursorPosition(97, 15);
            Console.WriteLine("╔══════╗");
            Console.SetCursorPosition(97, 16);
            Console.WriteLine("║  " + "██" + "  ║ (Cable 2)");
            Console.SetCursorPosition(97, 17);
            Console.WriteLine("╚══════╝");
            Console.WriteLine();
            x = 0;
            x = ran.Next(1, 5);
            switch (x)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                default:
                    Console.WriteLine("PENEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE");
                    break;
            }
            Console.SetCursorPosition(33, 19);

            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.SetCursorPosition(97, 18);
            Console.WriteLine("╔══════╗");
            Console.SetCursorPosition(97, 19);
            Console.WriteLine("║  " + "██" + "  ║ (Cable 3)");
            Console.SetCursorPosition(97, 20);
            Console.WriteLine("╚══════╝");
            Console.WriteLine();
            x = 0;
            x = ran.Next(1, 5);
            switch (x)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                default:
                    break;
            }
            Console.SetCursorPosition(33, 22);

            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.SetCursorPosition(97, 21);
            Console.WriteLine("╔══════╗");
            Console.SetCursorPosition(97, 22);
            Console.WriteLine("║  " + "██" + "  ║ (Cable 4)");
            Console.SetCursorPosition(97, 23);
            Console.WriteLine("╚══════╝");
            Console.WriteLine();
            x = 0;
            x = ran.Next(1, 5);
            switch (x)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                default:
                    Console.WriteLine("PENEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE");
                    break;
            }
            Console.SetCursorPosition(33, 25);

            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.SetCursorPosition(97, 24);
            Console.WriteLine("╔══════╗");
            Console.SetCursorPosition(97, 25);
            Console.WriteLine("║  " + "██" + "  ║ (Cable 5)");
            Console.SetCursorPosition(97, 26);
            Console.WriteLine("╚══════╝");
            Console.WriteLine();
            Console.ResetColor();
            int k = 0;
            int p = 0;
            int q = 0;
            int Z = 12;
            int s = 0;
            Console.SetCursorPosition(5, 5);
            Thread.Sleep(500);
            Console.WriteLine("Encuentra el cable");
            Console.SetCursorPosition(5, 6);
            Thread.Sleep(500);
            Console.WriteLine("con 25 de voltaje");
            Console.SetCursorPosition(5, 7);
            Thread.Sleep(500);
            Console.WriteLine("en caso de cortar");
            Console.SetCursorPosition(5, 8);
            Thread.Sleep(500);
            Console.WriteLine("un cable incorrecto");
            Console.SetCursorPosition(5, 9);
            Thread.Sleep(500);
            Console.WriteLine("este sumara el voltaje");
            Console.SetCursorPosition(5, 10);
            Thread.Sleep(500);
            Console.WriteLine("del cable al sistema");
            Console.SetCursorPosition(5, 11);
            Thread.Sleep(500);
            Console.WriteLine("si el sistema sobrepasa");
            Console.SetCursorPosition(5, 12);
            Thread.Sleep(500);
            Console.WriteLine("40 la alarma se ACTIVARA");
            menu1:
            k = k + q;
            Console.SetCursorPosition(5, 37);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Valor de sobrecarga " + k);
            Console.ResetColor();
            if (k >= 40)
            {
                Console.SetCursorPosition(5, 37);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valor de sobrecarga " + k);
                goto finalmalo;
            }
            else
            {
                popo:
                s = Z + 2;
                Z = Z + 2;
                menu2:
                Console.SetCursorPosition(5, s);
                Thread.Sleep(500);
                Console.WriteLine("¿Que cable deseas cortar?");
                try
                {
                    Console.SetCursorPosition(5, (s + 1));
                    p = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Z = Z - 2;
                    goto popo;
                }
                switch (p)
                {
                    case 1:
                        Console.SetCursorPosition(43, 13);
                        Console.WriteLine("░░░░░░░░░░");
                        Console.SetCursorPosition(100, 13);
                        Console.WriteLine(b);
                        q = 0;
                        q = b;
                        if (b == 25)
                        {
                            goto final;
                        }
                        else
                        {
                            goto menu1;
                        }
                    case 2:
                        Console.SetCursorPosition(43, 16);
                        Console.WriteLine("░░░░░░░░░░");
                        Console.SetCursorPosition(100, 16);
                        Console.WriteLine(g);
                        q = 0;
                        q = g;
                        if (g == 25)
                        {
                            goto final;
                        }
                        else
                        {
                            goto menu1;
                        }
                    case 3:
                        Console.SetCursorPosition(43, 19);
                        Console.WriteLine("░░░░░░░░░░");
                        Console.SetCursorPosition(100, 19);
                        Console.WriteLine(y);
                        q = 0;
                        q = y;
                        if (y == 25)
                        {
                            goto final;
                        }
                        else
                        {
                            goto menu1;
                        }
                    case 4:
                        Console.SetCursorPosition(43, 22);
                        Console.WriteLine("░░░░░░░░░░");
                        Console.SetCursorPosition(100, 22);
                        Console.WriteLine(r);
                        q = 0;
                        q = r;
                        if (r == 25)
                        {
                            goto final;
                        }
                        else
                        {
                            goto menu1;
                        }
                    case 5:
                        Console.SetCursorPosition(43, 25);
                        Console.WriteLine("░░░░░░░░░░");
                        Console.SetCursorPosition(100, 25);
                        Console.WriteLine(m);
                        q = 0;
                        q = m;
                        if (m == 25)
                        {
                            goto final;
                        }
                        else
                        {
                            goto menu1;
                        }
                    default:
                        Console.SetCursorPosition(5, (s + 2));
                        Console.WriteLine("No cortaste ningun cable");
                        s = Z + 2;
                        Z = Z + 2;
                        Thread.Sleep(1500);
                        goto menu2;
                }
            }
            final:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(5, 31);
            Console.WriteLine("Desactivaste la alarma :3");
            Console.SetCursorPosition(5, 32);
            Console.WriteLine("con exito");
            Console.SetCursorPosition(5, 33);
            goto gameover;
            finalmalo:
            Console.SetCursorPosition(5, 31);
            Console.WriteLine("SAL DE AHI, LA POLICIA");
            Console.SetCursorPosition(5, 32);
            Console.WriteLine("ESTA EN CAMINO");
            Console.SetCursorPosition(5, 33);
            Thread.Sleep(4000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            PANTALLA();
            FINAL_MALO();
            Thread.Sleep(4000);
            Environment.Exit(0);
            gameover:
            Thread.Sleep(4000);
        }                          //JUEGO 4 - ALARMA
        static void JUEGO_1()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            PANTALLA();
            INTERFAZ();
            SIGNOS_ALEATORIOS();
            PALABRAS_ALEATORIAS();
        }                          //JUEGO 1 - HACKEO
        static void JUEGO_1_DIFICIL()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            PANTALLA();
            INTERFAZ();
            SIGNOS_ALEATORIOS();
            PALABRAS_ALEATORIAS_DIFICIL();
        }                  //JUEGO 1 - HACKEO
        static void JUEGO_2()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            PANTALLA();
            MARCO_DE_INTERFAZ();
            CERROJO();
            MEDIDOR();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            BARRA_MEDIDOR();
            Console.ResetColor();
            GAME_LOOP();
            Thread.Sleep(3000);
        }                          //JUEGO 2 - LOCKPICK
        static void JUEGO_3()
        {
            int k = 0;
            Console.Clear();
            inicio:
            if (k == 2)
            {
                Console.Clear();
                JUEGO_4();
                goto end;
            }
            Console.Clear();
            PANTALLA();
            INTERFAZ_2();
            Console.SetCursorPosition(4, 2);
            Thread.Sleep(200);
            Console.WriteLine("La clave es la respuesta");
            Console.SetCursorPosition(4, 3);
            Thread.Sleep(200);
            Console.WriteLine("de las siguientes incógnitas");
            Console.SetCursorPosition(4, 4);
            Thread.Sleep(200);
            Console.WriteLine(". ");
            Console.SetCursorPosition(5, 4);
            Thread.Sleep(200);
            Console.WriteLine(". ");
            Console.SetCursorPosition(6, 4);
            Thread.Sleep(200);
            Console.WriteLine(".");
            Console.SetCursorPosition(4, 30);
            Thread.Sleep(200);
            Console.WriteLine("Cuentas con 2 intentos");
            Console.SetCursorPosition(4, 31);
            Thread.Sleep(200);
            Console.WriteLine("En caso de fallar la");
            Console.SetCursorPosition(4, 32);
            Thread.Sleep(200);
            Console.WriteLine("alarma se activara");
            Console.SetCursorPosition(7, 4);
            Random randominicial = new Random();
            int randominicial1 = randominicial.Next(1, 6);
            switch (randominicial1)
            {

                case 1: //CASO DEL 1500
                    Random random = new Random((int)DateTime.Now.Ticks);

                    string[] bancodepistas = { "7.5*(4/4)/2*4*100= ", "1500*1/2*(2/2)*2= ", "750*2= " };
                    string bancodepistasaleatorias = bancodepistas[random.Next(0, bancodepistas.Length)];
                    Console.SetCursorPosition(4, 7);
                    Console.WriteLine(bancodepistasaleatorias);
                    Console.SetCursorPosition(4, 7);
                    Console.WriteLine();
                    Console.SetCursorPosition(33, 2);

                    int respuesta;
                    try
                    {
                        respuesta = Convert.ToInt32(Console.ReadLine());
                        if (respuesta == 1500)
                        {
                            //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Yair\Documents\Visual Studio 2015\Projects\Ahorcado\Sonidos\Win.wav");
                            //player.Play();
                            Console.SetCursorPosition(33, 3);
                            Console.WriteLine("Acceso permitido.");
                        }
                        else
                        {
                            //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Yair\Documents\Visual Studio 2015\Projects\Ahorcado\Sonidos\Lose.wav");
                            //player.Play();
                            Console.SetCursorPosition(33, 3);
                            Console.WriteLine("Acceso denegado.");
                            Thread.Sleep(1000);
                            k = k + 1;
                            goto inicio;
                        }
                    }
                    catch (Exception)
                    {
                        //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Yair\Documents\Visual Studio 2015\Projects\Ahorcado\Sonidos\Default.wav");
                        //player.Play();
                        Console.SetCursorPosition(33, 3);
                        Console.WriteLine("Valor no permitido.");
                        Console.SetCursorPosition(33, 4);
                        Console.WriteLine("Presiona enter para volver a intentar");
                        Console.ReadLine();
                        goto inicio;
                    }


                    break;
                case 2: //CASO DEL 1
                    Random random2 = new Random((int)DateTime.Now.Ticks);

                    string[] bancodepistas2 = { "Deriva x= ", "8/4+(4-8)+3= ", "14/7/2= " };
                    string bancodepistasaleatorias2 = bancodepistas2[random2.Next(0, bancodepistas2.Length)];
                    Console.SetCursorPosition(4, 7);
                    Console.WriteLine(bancodepistasaleatorias2);
                    Console.SetCursorPosition(4, 7);
                    Console.WriteLine();
                    Console.SetCursorPosition(33, 2);
                    int respuesta2;
                    try
                    {
                        respuesta2 = Convert.ToInt32(Console.ReadLine());
                        if (respuesta2 == 1)
                        {
                            Console.SetCursorPosition(33, 3);
                            //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Yair\Documents\Visual Studio 2015\Projects\Ahorcado\Sonidos\Win.wav");
                            //player.Play();
                            Console.WriteLine("Acceso permitido.");
                        }
                        else
                        {
                            //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Yair\Documents\Visual Studio 2015\Projects\Ahorcado\Sonidos\Lose.wav");
                            //player.Play();
                            Console.SetCursorPosition(33, 3);
                            Console.WriteLine("Acceso denegado.");
                            Thread.Sleep(1000);
                            k = k + 1;
                            goto inicio;
                        }
                    }
                    catch (Exception)
                    {
                        //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Yair\Documents\Visual Studio 2015\Projects\Ahorcado\Sonidos\Default.wav");
                        //player.Play();
                        Console.SetCursorPosition(33, 3);
                        Console.WriteLine("Valor no permitido.");
                        Console.SetCursorPosition(33, 4);
                        Console.WriteLine("Presiona enter para volver a intentar.");
                        Console.ReadLine();
                        goto inicio;
                    }
                    break;
                case 3: //CASO DEL 0
                    Random random3 = new Random((int)DateTime.Now.Ticks);

                    string[] bancodepistas3 = { "(3*(3/4)^2-4/4)*0= ", "7*1/2*0= ", "Deriva 8*6= " };
                    string bancodepistasaleatorias3 = bancodepistas3[random3.Next(0, bancodepistas3.Length)];
                    Console.SetCursorPosition(4, 7);
                    Console.WriteLine(bancodepistasaleatorias3);
                    Console.SetCursorPosition(4, 7);
                    Console.WriteLine();
                    Console.SetCursorPosition(33, 2);
                    int respuesta3;
                    try
                    {
                        respuesta3 = Convert.ToInt32(Console.ReadLine());
                        if (respuesta3 == 0)
                        {
                            //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Yair\Documents\Visual Studio 2015\Projects\Ahorcado\Sonidos\Win.wav");
                            //player.Play();
                            Console.SetCursorPosition(33, 3);
                            Console.WriteLine("Acceso permitido.");
                        }
                        else
                        {
                            //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Yair\Documents\Visual Studio 2015\Projects\Ahorcado\Sonidos\Lose.wav");
                            //player.Play();
                            Console.SetCursorPosition(33, 3);
                            Console.WriteLine("Acceso denegado.");
                            k = k + 1;
                            Thread.Sleep(1000);
                            goto inicio;
                        }
                    }
                    catch (Exception)
                    {
                        //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Yair\Documents\Visual Studio 2015\Projects\Ahorcado\Sonidos\Default.wav");
                        //player.Play();
                        Console.SetCursorPosition(33, 3);
                        Console.WriteLine("Valor no permitido.");
                        Console.SetCursorPosition(33, 4);
                        Console.WriteLine("Presiona enter para volver a intentar.");
                        Console.ReadLine();
                        goto inicio;
                    }
                    break;
                case 4: //CASO DEL 17
                    Random random4 = new Random((int)DateTime.Now.Ticks);

                    string[] bancodepistas4 = { "14/2+7-24+48/2+3= ", "(80/2)/2-3= ", "50/2-5-3= " };
                    string bancodepistasaleatorias4 = bancodepistas4[random4.Next(0, bancodepistas4.Length)];
                    Console.SetCursorPosition(4, 7);
                    Console.WriteLine(bancodepistasaleatorias4);
                    Console.SetCursorPosition(4, 7);
                    Console.WriteLine();
                    Console.SetCursorPosition(33, 2);
                    int respuesta4;
                    try
                    {
                        respuesta4 = Convert.ToInt32(Console.ReadLine());
                        if (respuesta4 == 17)
                        {
                            //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Yair\Documents\Visual Studio 2015\Projects\Ahorcado\Sonidos\Win.wav");
                            //player.Play();
                            Console.SetCursorPosition(33, 3);
                            Console.WriteLine("Acceso permitido.");
                        }
                        else
                        {
                            //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Yair\Documents\Visual Studio 2015\Projects\Ahorcado\Sonidos\Lose.wav");
                            //player.Play();
                            Console.SetCursorPosition(33, 3);
                            Console.WriteLine("Acceso denegado.");
                            k = k + 1;
                            Thread.Sleep(1000);
                            goto inicio;
                        }
                    }
                    catch
                    {
                        //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Yair\Documents\Visual Studio 2015\Projects\Ahorcado\Sonidos\Default.wav");
                        //player.Play();
                        Console.SetCursorPosition(33, 3);
                        Console.WriteLine("Valor no permitido.");
                        Console.SetCursorPosition(33, 4);
                        Console.WriteLine("Presiona enter para volver a intentar");
                        Console.ReadLine();
                        goto inicio;
                    }
                    break;
                case 5: //AHORCADO
                    Random random5 = new Random((int)DateTime.Now.Ticks);
                    Console.SetCursorPosition(4, 7);
                    Console.WriteLine("**INSTRUCCIONES**");
                    Console.SetCursorPosition(4, 8);
                    Console.WriteLine("-Las palabras a adivinar");
                    Console.SetCursorPosition(4, 9);
                    Console.WriteLine("están en minúsculas.");
                    Console.SetCursorPosition(4, 10);
                    Console.WriteLine("-Están escritas sin acentos.");
                    Console.SetCursorPosition(4, 11);
                    Console.WriteLine("-Van relacionadas con la");
                    Console.SetCursorPosition(4, 12);
                    Console.WriteLine("asignatura.");
                    Console.SetCursorPosition(4, 13);
                    Console.WriteLine("-Debes ingresar sólo");
                    Console.SetCursorPosition(4, 14);
                    Console.WriteLine("una letra a la vez.");
                    Console.SetCursorPosition(4, 15);
                    Console.WriteLine("-Tienes tres vidas.");
                    Console.SetCursorPosition(4, 16);
                    Console.WriteLine("(Aprieta cualquier tecla");
                    Console.SetCursorPosition(4, 17);
                    Console.WriteLine("para iniciar el juego).");
                    Console.SetCursorPosition(4, 18);




                    Console.ReadKey();


                    string[] bancodepalabras = { "Programa", "Codigo", "Libreria", "Consola" };

                    string palabraparaadivinar = bancodepalabras[random5.Next(0, bancodepalabras.Length)];
                    string palabraparaadivinarUppercase = palabraparaadivinar.ToUpper();

                    StringBuilder pantallaparaeljugador = new StringBuilder(palabraparaadivinar.Length);
                    for (int i = 0; i < palabraparaadivinar.Length; i++)

                        pantallaparaeljugador.Append('_');

                    List<char> pistascorrectas = new List<char>();
                    List<char> pistasincorrectas = new List<char>();

                    int vidas = 3;
                    bool ganar = false;
                    int letrasreveladas = 0;

                    string entrada;
                    char pista;

                    while (!ganar && vidas > 0)
                    {

                        Console.SetCursorPosition(33, 2);
                        Console.Write("Adivina una letra: ");
                        entrada = Console.ReadLine().ToUpper();
                        try
                        {
                            pista = entrada[0];
                        }
                        catch (Exception)
                        {
                            //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Yair\Documents\Visual Studio 2015\Projects\Ahorcado\Sonidos\Default.wav");
                            //player.Play();
                            Console.SetCursorPosition(33, 3);
                            Console.WriteLine("Valor no permitido.");
                            Console.SetCursorPosition(33, 4);
                            Console.WriteLine("Presiona enter para volver a intentar.");
                            Console.ReadLine();
                            goto inicio;
                        }

                        if (pistascorrectas.Contains(pista))
                        {
                            //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Yair\Documents\Visual Studio 2015\Projects\Ahorcado\Sonidos\Correct_answer.wav");
                            //player.Play();
                            Console.SetCursorPosition(33, 4);
                            Console.WriteLine("¡Ya intentaste '{0}', y estuvo bien!               ", pista);

                            continue;
                        }
                        else if (pistasincorrectas.Contains(pista))
                        {
                            //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Yair\Documents\Visual Studio 2015\Projects\Ahorcado\Sonidos\Default.wav");
                            //player.Play();
                            Console.SetCursorPosition(33, 4);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("¡Ya intentaste '{0}', y estuvo mal!          ", pista);
                            continue;
                        }

                        if (palabraparaadivinarUppercase.Contains(pista))
                        {
                            Console.SetCursorPosition(33, 3); //////////////////
                            pistascorrectas.Add(pista);
                            Console.SetCursorPosition(33, 4);
                            Console.WriteLine("Acertaste                               ", pista);


                            for (int i = 0; i < palabraparaadivinar.Length; i++)
                            {
                                if (palabraparaadivinarUppercase[i] == pista)
                                {
                                    Console.SetCursorPosition(33, 3);//////////////
                                    pantallaparaeljugador[i] = palabraparaadivinar[i];
                                    letrasreveladas++;
                                }
                            }

                            if (letrasreveladas == palabraparaadivinar.Length)
                                ganar = true;
                        }
                        else
                        {
                            Console.SetCursorPosition(33, 3);////////////
                            pistasincorrectas.Add(pista);
                            //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Yair\Documents\Visual Studio 2015\Projects\Ahorcado\Sonidos\Default.wav");
                            //player.Play();
                            Console.SetCursorPosition(33, 4);
                            Console.WriteLine("¡No, no existe una '{0}' en la palabra!            ", pista);
                            vidas--;
                        }
                        Console.SetCursorPosition(33, 3);///////////
                        Console.WriteLine(pantallaparaeljugador.ToString());
                    }

                    if (ganar)
                    {

                        //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Yair\Documents\Visual Studio 2015\Projects\Ahorcado\Sonidos\Win.wav");
                        //player.Play();
                        Console.SetCursorPosition(33, 5);
                        Console.WriteLine("Acceso permitido                            ");
                    }
                    else
                    {
                        Console.SetCursorPosition(33, 4);
                        //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Yair\Documents\Visual Studio 2015\Projects\Ahorcado\Sonidos\Lose.wav");
                        //player.Play();
                        Console.WriteLine("Acceso denegado Era '{0}'                         ", palabraparaadivinar);

                        Console.SetCursorPosition(33, 6);
                        Thread.Sleep(1000);
                        k = k + 1;
                        goto inicio;
                    }

                    Thread.Sleep(500);
                    break;
                default:
                    break;
            }
            end:
            Thread.Sleep(2000);
        }                          //JUEGO 3 - AHORCADO

        static void MAPA_INICIAL()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            PANTALLA();
            INTERFAZ_2();
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i <= 26; i++)      // vertical interior izquierda 
            {
                Console.SetCursorPosition(65, (i + 7));
                Console.WriteLine("█");
            }
            for (int i = 0; i <= 62; i++)
            {
                Console.SetCursorPosition((i + 44), 15);
                Console.WriteLine("█");
            }
            for (int i = 0; i <= 62; i++)
            {
                Console.SetCursorPosition((i + 44), 24);
                Console.WriteLine("█");
            }
            for (int i = 0; i <= 26; i++)  //vertical interior derecha
            {
                Console.SetCursorPosition(86, (i + 7));
                Console.WriteLine("█");
            }
            for (int i = 0; i <= 62; i++) //horizontal superior
            {
                Console.SetCursorPosition((i + 44), 6);
                Console.WriteLine("█");
            }
            for (int i = 0; i <= 26; i++) //vertical izquierda
            {
                Console.SetCursorPosition(44, (i + 6));
                Console.WriteLine("█");
            }
            for (int i = 0; i <= 62; i++) //horizontal inferior
            {
                Console.SetCursorPosition((i + 44), 33);
                Console.WriteLine("█");
            }
            for (int i = 0; i <= 26; i++)  //vertical derecha
            {
                Console.SetCursorPosition(106, (i + 6));
                Console.WriteLine("█");
            }
            //ELEMENTOS EN EL MAPA
            Console.ForegroundColor = ConsoleColor.DarkYellow;  //PUERTA ENTRADA PRINCIPAL
            Console.SetCursorPosition(52, 6);
            Console.WriteLine("═════");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(50, 5);
            Console.WriteLine("█       █");
            Console.ForegroundColor = ConsoleColor.DarkBlue;  //PUERTA ENTRADA PRINCIPAL
            Console.SetCursorPosition(52, 33);
            Console.WriteLine("═════");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(50, 34);
            Console.WriteLine("█       █");
            Console.SetCursorPosition(50, 35);
            Console.WriteLine("█       █");
            Console.SetCursorPosition(65, 13);
            Console.ForegroundColor = ConsoleColor.DarkBlue;    //PUERTA SUPERIOR IZQUIERDA     
            Console.WriteLine("║");
            Console.SetCursorPosition(86, 13);
            Console.ForegroundColor = ConsoleColor.DarkBlue;  //PUERTA SUPERIOR CENTRO
            Console.WriteLine("║");
            Console.SetCursorPosition(65, 22);
            Console.ForegroundColor = ConsoleColor.DarkYellow;   //PUERTA MEDIA IZQUIERDA
            Console.WriteLine("║");
            Console.SetCursorPosition(86, 26);
            Console.ForegroundColor = ConsoleColor.DarkBlue;  //PUERTA INFERIOR DERECHA (IZQUIERDA)
            Console.WriteLine("║");
            Console.SetCursorPosition(100, 24);
            Console.ForegroundColor = ConsoleColor.DarkBlue;  //PUERTA INFERIOR DERECHA (ARRIBA)
            Console.WriteLine("══");
            Console.SetCursorPosition(100, 15);
            Console.ForegroundColor = ConsoleColor.DarkYellow;  //PUERTA SUPERIOR DERECHA (ABAJO)
            Console.WriteLine("══");
            Console.SetCursorPosition(70, 24);
            Console.ForegroundColor = ConsoleColor.DarkYellow;   //PUERTA MEDIO ARRIBA
            Console.WriteLine("══");
            Console.SetCursorPosition(48, 24);
            Console.ForegroundColor = ConsoleColor.DarkYellow;   //PUERTA IZQUIERDA ARRIBA
            Console.WriteLine("══");
            Console.ResetColor();
            Console.SetCursorPosition(35, 22);
            Console.WriteLine(" -w-");
            Console.SetCursorPosition(35, 23);
            Console.WriteLine(" ┌|┐");
            Console.SetCursorPosition(35, 24);
            Console.WriteLine("  | ");
            Console.SetCursorPosition(35, 25);
            Console.WriteLine(" / \\");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(88, 8);       //CAJA FUERTE
            Console.WriteLine("╔═════╗");
            Console.SetCursorPosition(88, 9);
            Console.WriteLine("║╔═╦═╗║");
            Console.SetCursorPosition(88, 10);
            Console.WriteLine("║╠═O═╣║");
            Console.SetCursorPosition(88, 11);
            Console.WriteLine("║╚═╩═╝║");
            Console.SetCursorPosition(88, 12);
            Console.WriteLine("╚═════╝");
            Console.ForegroundColor = ConsoleColor.Gray;   //COMPUTADORAS
            Console.SetCursorPosition(67, 8);
            Console.WriteLine("╔══════╗");
            Console.SetCursorPosition(67, 9);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(67, 10);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(67, 11);
            Console.WriteLine("╚══╦╦══╝");
            Console.SetCursorPosition(67, 12);
            Console.WriteLine("╔╦╦╦╦╦╦╗");
            Console.SetCursorPosition(67, 13);
            Console.WriteLine("╚╩╩╩╩╩╩╝");
            Console.SetCursorPosition(46, 26);
            Console.WriteLine("╔══════╗");
            Console.SetCursorPosition(46, 27);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(46, 28);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(46, 29);
            Console.WriteLine("╚══╦╦══╝");
            Console.SetCursorPosition(46, 30);
            Console.WriteLine("╔╦╦╦╦╦╦╗");
            Console.SetCursorPosition(46, 31);
            Console.WriteLine("╚╩╩╩╩╩╩╝");
            Console.SetCursorPosition(46, 8);
            Console.WriteLine("╔══════╗");
            Console.SetCursorPosition(46, 9);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(46, 10);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(46, 11);
            Console.WriteLine("╚══╦╦══╝");
            Console.SetCursorPosition(46, 12);
            Console.WriteLine("╔╦╦╦╦╦╦╗");
            Console.SetCursorPosition(46, 13);
            Console.WriteLine("╚╩╩╩╩╩╩╝");
            Console.SetCursorPosition(46, 17);
            Console.WriteLine("╔══════╗");
            Console.SetCursorPosition(46, 18);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(46, 19);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(46, 20);
            Console.WriteLine("╚══╦╦══╝");
            Console.SetCursorPosition(46, 21);
            Console.WriteLine("╔╦╦╦╦╦╦╗");
            Console.SetCursorPosition(46, 22);
            Console.WriteLine("╚╩╩╩╩╩╩╝");
            Console.SetCursorPosition(67, 17);
            Console.WriteLine("╔══════╗");
            Console.SetCursorPosition(67, 18);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(67, 19);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(67, 20);
            Console.WriteLine("╚══╦╦══╝");
            Console.SetCursorPosition(67, 21);
            Console.WriteLine("╔╦╦╦╦╦╦╗");
            Console.SetCursorPosition(67, 22);
            Console.WriteLine("╚╩╩╩╩╩╩╝");
            Console.SetCursorPosition(88, 17);
            Console.WriteLine("╔══════╗");
            Console.SetCursorPosition(88, 18);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(88, 19);
            Console.WriteLine("║      ║");
            Console.SetCursorPosition(88, 20);
            Console.WriteLine("╚══╦╦══╝");
            Console.SetCursorPosition(88, 21);
            Console.WriteLine("╔╦╦╦╦╦╦╗");
            Console.SetCursorPosition(88, 22);
            Console.WriteLine("╚╩╩╩╩╩╩╝");
            Console.ResetColor();
            Console.ReadLine();
        }                   //MAPA

        static void CARGANDO()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.CursorVisible = false;
            Console.SetCursorPosition(4, 2);
            Thread.Sleep(500);
            Console.WriteLine("1. JUGAR");
            Console.SetCursorPosition(4, 4);
            Thread.Sleep(500);
            Console.WriteLine("2. SALIR");
            Console.SetCursorPosition(4, 6);
            int w = 0;
            lul:
            try
            {
                w = Convert.ToInt32(Console.ReadLine());
            } 
            catch (Exception)
            {
                goto lul;
            }
            if (w== 1)
            {
                Console.Clear();
            }
            else
            {
                Environment.Exit(0);
            }
        }         //MENU
        static void GAME_LOOP_MAIN()
        {
            PANTALLADEINICIO();
            PANTALLA_AZUL();
            INTERFAZ_2();
            BIENVENIDO();
            CARGANDO();
            Console.CursorVisible = false;
            MAPA_INICIAL();
            Console.CursorVisible = true;
            CONVERSACION_INTRO();

            Console.CursorVisible = false;
            Console.SetCursorPosition(4, 15);
            Thread.Sleep(500);
            Console.WriteLine("1. CAMINO DIFICIL/CORTO");
            Console.SetCursorPosition(4, 17);
            Thread.Sleep(500);
            Console.WriteLine("2. CAMINO FACIL/LARGO");
            lel:
            ConsoleKeyInfo tecla;
            try
            {
                tecla = Console.ReadKey(false);

            }
            catch (FormatException)
            {
                goto lel;
            }
            if (tecla.KeyChar == '1')
            {
                Console.Clear();
                PANTALLA();
                INTERFAZ_2();
                MAPA_CORTO();
                CONVERSACION_CAMINO_CORTO();
                Console.Clear();
                JUEGO_2();
                Console.Clear();
                Mapa1_1();
                Console.Clear();
                JUEGO_1_DIFICIL();
                Console.Clear();
                JUEGO_3();
                Console.Clear();
                Mapa1_2();
                Console.Clear();
                JUEGO_1_DIFICIL();
                Console.Clear();
                JUEGO_3();
                Console.Clear();
                Mapa1_3();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                PANTALLA();
                FINAL_BUENO();


            }
            else if (tecla.KeyChar == '2')
            {
                Console.Clear();
                PANTALLA();
                INTERFAZ_2();
                MAPA_LARGO();
                CONVERSACION_CAMINO_LARGO();
                Console.Clear();
                JUEGO_3();
                Console.Clear();
                Mapa3_1();
                Console.Clear();
                JUEGO_1();
                Console.Clear();
                JUEGO_2();
                Console.Clear();
                Mapa2_1();
                Console.Clear();
                JUEGO_1();
                Console.Clear();
                JUEGO_2();
                Console.Clear();
                Mapa2_2();
                Console.Clear();
                JUEGO_1();
                Console.Clear();
                JUEGO_2();
                Console.Clear();
                Mapa3_2();
                Console.Clear();
                JUEGO_3();
                Console.Clear();
                Mapa3_3();
                Console.Clear();
                JUEGO_3();
                Console.Clear();
                Mapa2_3();
                Console.Clear();
                JUEGO_1();
                Console.Clear();
                JUEGO_2();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                PANTALLA();
                FINAL_BUENO();
            }
            Thread.Sleep(10000);
        }

        static void Main(string[] args)
        {
            GAME_LOOP_MAIN();
        }
    }
}
