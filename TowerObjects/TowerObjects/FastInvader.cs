﻿using System;


namespace TowerDefense
{
    class FastInvader : Invader
    {
        protected override int StepSize {get;} = 2; //{get{return 1;}}
        public override double Health { get; protected set; } =2;//Set Health of FastInvader to 2

        public FastInvader(Path path) :base(path)
        {
            Console.WriteLine("We Got A Runner!");
        }
    }
}
