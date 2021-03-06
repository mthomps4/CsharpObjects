﻿namespace TowerDefense
{
    abstract class Invader : IInvader //Invader Impliments IInvader interface.  //Creates Abstract base class for "basic Invader" Only Strong,Fast,Shielded etc are concrete usable Invaders. BasicInvader.cs
    {
        //private MapLocation _location;

        //public MapLocation Location
        //{
        //   get { return _location; }
        //  private set { _location = value;}
        //}
        //For C# auto make get and set with 'public MapLocation Location { get; private set; }' remove field. 

        public MapLocation Location
        {
            get
            {
                return _path.GetLocationAt(_pathStep);
            }
        }

        //Above can be rewritten as 'public MapLocation Location => _path.GetLocationAt(_pathStep);'

        //Invader Health 
        public abstract double Health { get; protected set; } //Abstract Health set for set classes of Invader

        //True if Invader has reached end of path. 
        public bool HasScored { get { return _pathStep >= _path.Length; } }

        //True if Invaders Health = 0 
        public bool IsNeutralized => Health <= 0;

        public bool IsActive => !(IsNeutralized || HasScored);

        //Path object to be accessed later 
        private readonly Path _path; 

        //Path step to know when Invader makes it to end of path 
        private int _pathStep = 0; //initial value set to 0 

        protected virtual int StepSize { get; } = 1; //{get{return 1;}} //protected happy medium between public and private

  
        //To keep from returning null initially use constructor 
        public Invader(Path path)
        {
            _path = path; //Used from above 
        }

        //Tell invader to move 
        public void Move() => _pathStep += StepSize;

        public virtual void DecreaseHealth(double factor) //Keyword virtual added for Polymorphic Object (ShieldedInvader) Tells code this is One possible solution and that subclasses can provide their own. 
        {
            Health -= factor;
            System.Console.WriteLine("Shot and hit an invader!");
        }
    }
}

//Invader Class 
//path 
//pathStep 
//location property 
//Move method 