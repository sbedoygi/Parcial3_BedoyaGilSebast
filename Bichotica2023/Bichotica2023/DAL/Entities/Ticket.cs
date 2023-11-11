using System.ComponentModel.DataAnnotations;

namespace Bichotica2023.DAL.Entities
{
    public class Ticket : Entity
    {
        #region
        [Display(Name = "Ingrese su Ticket")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public int TicketID { get; set; }

        [Display(Name = "Confirmacion Fecha Activación")]
        public DateTime? UseDate { get; set; }

        [Display(Name = "Ticket Activo")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public bool IsUsed { get; set; }

        [Display(Name = "Selecione nombre de la entrada es requerido")]
    
        public Entrance? EntranceGate { get; set; }

        public enum Entrance
        {
            Oriental,
            Occidental,
            Norte,
            Sur,

        }
      


    }
    #endregion
}