
using System;
using System.Collections.Generic;

namespace CAdvanced
{
    public delegate void MenuDelegate(object sender, MenuEventArgs e);

    public class Menu
    {
        public event MenuDelegate PressEnter;


        private int _current;
        private readonly List<string> _menuItems;
        private readonly ConsoleColor _hBackColor;
        private readonly ConsoleColor _hForeColor;
        private readonly ConsoleColor _backColor;
        private readonly ConsoleColor _foreColor;
        private readonly int _x;
        private readonly int _y;



        public Menu(List<string> menuItems, ConsoleColor hBackColor, ConsoleColor hForeColor, ConsoleColor backColor,
            ConsoleColor foreColor, int x, int y)
        {
            PressEnter = OnPressEnter;
            _menuItems = menuItems;
            _hBackColor = hBackColor;
            _hForeColor = hForeColor;
            _backColor = backColor;
            _foreColor = foreColor;
            _x = x;
            _y = y;
            _current = 0;
        }

        public Menu(List<string> menuItems, ConsoleColor hBackColor, ConsoleColor hForeColor, int x, int y)
            : this(
                menuItems, hBackColor, hForeColor, ConsoleColor.Black, ConsoleColor.White, x, y)
        {

        }

        private void Draw()
        {
            for (var i = 0; i < _menuItems.Count; i++)
            {
                Console.SetCursorPosition(_x, _y + i);
                if (i == _current)
                {
                    Console.BackgroundColor = _hBackColor;
                    Console.ForegroundColor = _hForeColor;
                }
                else
                {
                    Console.BackgroundColor = _backColor;
                    Console.ForegroundColor = _foreColor;
                }
                Console.WriteLine(_menuItems[i]);
            }
            Console.ResetColor();
        }

        public void Show()
        {

            MenuEventArgs arg = new MenuEventArgs(_current);
            do
            {
                Draw();
                var cki = Console.ReadKey(true);

                switch (cki.Key)
                {
                    case ConsoleKey.UpArrow:
                        _current--;
                        if (_current < 0)
                        {
                            _current = _menuItems.Count - 1;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        _current++;
                        if (_current == _menuItems.Count)
                        {
                            _current = 0;
                        }
                        break;
                    case ConsoleKey.Enter:
                        arg = new MenuEventArgs(_current);
                        if (PressEnter != null) PressEnter(this, arg);
                        break;
                    case ConsoleKey.Escape:
                        arg.IsExit = false;
                        break;
                    case ConsoleKey.Home:
                        _current = 0;
                        break;
                    case ConsoleKey.End:
                        _current = _menuItems.Count - 1;
                        break;

                }
            } while (!arg.IsExit);

        }

        public void OnPressEnter(object sender, MenuEventArgs e)
        {

        }
    }
}
