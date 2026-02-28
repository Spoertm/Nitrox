namespace NitroxClient.GameLogic.PlayerLogic.PlayerModel.ColorSwap
{
    public sealed class ColorValueRange
    {
        private readonly float min;
        private readonly float max;

        public ColorValueRange(float min, float max)
        {
            this.min = min;
            this.max = max;
        }

        public bool Covers(float targetValue)
        {
            return min <= targetValue && targetValue <= max;
        }
    }
}
