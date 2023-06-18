using System.ComponentModel;

namespace SistemaDeTarefas.Enums
{
    public enum StatusTarefas : int
    {
        [Description ("A fazer")]
        Afazer = 1,
        [Description("Em andamento")]
        EmAndamento = 2,
        [Description("Concluído")]
        Concluido = 3 
    }
}
