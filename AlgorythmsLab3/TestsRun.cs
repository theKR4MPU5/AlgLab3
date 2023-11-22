using AlgLab3.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgLab3
{
    public class TestsRun
    {
        public static void Tests()
        {


            //AlgLab3.Testing.Testing.TestQueueRandomInFile(func: x => TestQueue.TestingQueueFile(x),
            //    name: "Рандомные команды из файла (Очередь)",
            //    iterCount: 1);

            //AlgLab3.Testing.Testing.TestStackRandomInFile(func: x => TestStack.TestingStackFile(x),
            //    name: "Рандомные команды из файла (Стэк)",
            //    iterCount: 1);

            //AlgLab3.Testing.Testing.TestStackSpecificCommands(x => TestStack.TestingStack(x), name: "Pop Push (Стэк)",
            //    iterCount: 1, 1, 2);

            //AlgLab3.Testing.Testing.TestQueueSpecificCommands(func: x => TestQueue.TestingQueue(x),
            //    name: "Enqueue Decueue (Очередь)", iterCount: 1, 1, 2); 

            AlgLab3.Testing.Testing.TestStackRandom(func: x => TestStack.TestingStack(x), name: "Рандомные команды (Стэк)",
                iterCount: 1);
            
            AlgLab3.Testing.Testing.TestSharpQueueRandom(func: x => TestQueue.TestingQueueSharpRandom(x),
                name: "Рандомные команды (Sharp Queue)",
                iterCount: 1);
            AlgLab3.Testing.Testing.TestSharpStackRandom(func: x => TestStack.TestSharpStackRandom(x),
                name: "Рандомные команды (Sharp Stack)",
                iterCount: 1);

            AlgLab3.Testing.Testing.TestQueueRandom(func: x => TestQueue.TestingQueue(x), name: "Рандомные команды (Очередь)",
                iterCount: 1);
                          
            AlgLab3.Testing.Testing.TestQueueConst(func: x => TestQueue.TestingQueue(x),
                name: "Одинаковые по длине рандомные команды (Очередь)", iterCount: 1);


        }
    }
}
