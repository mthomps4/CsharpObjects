

namespace TowerDefense
{
    class BasicInvader : Invader
    {
        public BasicInvader(Path path) : base(path)
        { }
        public override double Health { get; protected set; } = 2;//Set Health of FastInvader to 2

    }
}
