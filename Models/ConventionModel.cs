using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ConventionStage.Models
{
    public class ConventionModel
    {
        [Display(Name = "ID Etudiant")]
        //[Range(10000, 99999, ErrorMessage = "You need to enter a valid student ID")]
        public int IdEtudiant { get; set; }

        [Display(Name = "Nom de l'entreprise")]
        [Required(ErrorMessage = "Vous devez renseigner un nom d'entreprise")]
        public string NomEntreprise { get; set; }

        [Display(Name = "Ville")]
        [Required(ErrorMessage = "Vous devez renseigner le lieu du stage")]
        public string Ville { get; set; }

        [Display(Name = "Date de début")]
        [Required(ErrorMessage = "Vous devez renseigner une date de debut")]
        public DateTime DateDebut { get; set; }

        [Display(Name = "Date de fin")]
        [Required(ErrorMessage = "Vous devez renseigner une date de fin")]
        public DateTime DateFin { get; set; }

        public string Etat { get; set; }
    }
}