﻿using System;
using System.Collections.Generic;
using System.Linq;
using AlgLab3.Console.functions;
using AlgLab3.Tools;

namespace AlgLab3.Console
{
    public abstract class Menu : MenuItem
    {
        protected List<MenuItem> Items;

        public Menu(string title, List<MenuItem> items, bool isSelected = false) : base(title, isSelected)
        {
            if (this.GetType() != typeof(MainMenu)) 
            {
                items.Add(new ExitMenuItem());
            }

            if (!items.Any(x => x.IsSelected))
            {
                items.First().IsSelected = true;
            }
            Items = items;
        }

        public override void Execute()
        {
            Start();
        }

        public void Start()
        {
            System.Console.CursorVisible = false;
            bool canExit = false;
            do
            {
                DrawMenu();
                ConsoleKeyInfo inputKey = System.Console.ReadKey(true);
                switch (inputKey.Key)
                {
                    case ConsoleKey.DownArrow:
                        MenuNext();
                        break;
                    case ConsoleKey.UpArrow:
                        MenuPrev();
                        break;
                    case ConsoleKey.Enter:
                        MenuItem item = Items.First(item => item.IsSelected);
                        if (item.Equals(Items.Last()))
                        {
                            canExit = true;
                        }
                        else
                        {
                            item.Execute();
                        }

                        break;
                }
            } while (!canExit);
        }

        private void MenuPrev()
        {
            ConsoleUtil.ClearScreen();
            MenuItem select = Items.First(item => item.IsSelected);
            int selectindex = Items.IndexOf(select);
            Items[selectindex].IsSelected = false;
            selectindex = selectindex == 0
                ? Items.Count - 1
                : --selectindex;
            Items[selectindex].IsSelected = true;
        }

        private void MenuNext()
        {
            ConsoleUtil.ClearScreen();
            MenuItem select = Items.First(item => item.IsSelected);
            int selectIndex = Items.IndexOf(select);
            Items[selectIndex].IsSelected = false;
            selectIndex = selectIndex == Items.Count - 1
                ? 0
                : ++selectIndex;
            Items[selectIndex].IsSelected = true;
        }

        private void DrawMenu()
        {
            ConsoleUtil.ClearScreen();
            foreach (var item in Items)
            {
                System.Console.BackgroundColor = item.IsSelected
                    ? ConsoleColor.Magenta
                    : ConsoleColor.Black;
                System.Console.WriteLine(item.Title);
                System.Console.BackgroundColor = ConsoleColor.Black;
            }
        }
    }
}