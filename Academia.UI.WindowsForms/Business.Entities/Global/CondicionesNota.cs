namespace Business.Entities.Global
{
    public static class CondicionesNota
    {
        public const int MinimoAprobado = (int)CondicionNota.MinimoAprobado;

        public const int MinimoRegular = (int)CondicionNota.MinimoRegular;

        private enum CondicionNota
        {
            MinimoAprobado = 6,
            MinimoRegular = 4,
        }
    }
}
