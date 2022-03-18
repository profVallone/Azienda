using System;
using System.Runtime.Serialization;

namespace GestioneAzienda
{
    [Serializable]
    internal class GradoDipendentiErrato : Exception
    {
        public GradoDipendentiErrato()
        {
        }

        public GradoDipendentiErrato(string message) : base(message)
        {
        }

        public GradoDipendentiErrato(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected GradoDipendentiErrato(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}