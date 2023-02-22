using System.Runtime.Serialization;

namespace prueba_intento2.enums
{
    public enum TipoDocumentos
    {
        [EnumMember(Value = "CEDULA_CIUDADANIA")]
        CEDULA_CIUDADANIA,
        [EnumMember(Value = "CEDULA_EXTRANJERA")]
        CEDULA_EXTRANJERA,
        [EnumMember(Value = "PASAPORTE")]
        PASAPORTE,
        [EnumMember(Value = "OTROS")]
        OTROS

    }
}
