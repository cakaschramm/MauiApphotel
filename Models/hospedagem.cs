using MauiApphotel.Properties.Models;

namespace MauiApphotel.Models
{
    public class hospedagem
    {
        public Quarto? QuartoSelecionado { get; set; }
        public int QntAdultos { get; set; }
        public int QntCriancas { get; set; }
        public DateTime? DataCheckIn { get; set; }
        public DateTime? DataCheckOut { get; set; }
    }
}