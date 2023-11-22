﻿using System;
using System.Collections.Generic;
using AlgLab3.Console.functions.list;

namespace AlgLab3.Console.menus
{
    public class FourthTaskMenu : Menu
    {
        private static readonly Structures.LinkedList.LinkedList<int> List = GenerateList();

        public FourthTaskMenu(bool isSelected = false) : base(title: "4 Задание: Лист", items: new List<MenuItem>()
        {
            new ReverseList(list: List),
            new SwapFirstAndLast(list: List),
            new CountDistinctElements(list: List),
            new RemoveEverSecondElement(list: List),
            new InsertYourself(list: List),
            new InsertElementByOrder(list: List),
            new RemoveElements(list: List),
            new Insert(list: List),
            new Concat(list: List),
            new Split(list: List),
            new DoublingList(list: List),
            new Swap(list: List)
        }, isSelected: isSelected)
        {
        }

        private static Structures.LinkedList.LinkedList<int> GenerateList()
        {
            Structures.LinkedList.LinkedList<int> list = new Structures.LinkedList.LinkedList<int>();
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                list.Add(random.Next(0, 20));
            }

            return list;
        }
    }
}