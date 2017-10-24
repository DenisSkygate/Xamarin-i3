using System;
using System.Collections.Generic;
namespace UXDivers.Artina.Grial
{
	public class Personne
	{
		public string nom{ get; set; }
		public string prenom{ get; set; }
		public DateTime dateNaissance{ get; set; }
		public List<Vehicule> vehicules { get; set; }

		public Personne()
		{
			vehicules = new List<Vehicule>();
		}
	}
}
