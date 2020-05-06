using AfpaTinderMvc.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AfpaTinderMvc.InitDataBase
{
    public class AfpaTinderDbInit : DropCreateDatabaseAlways<AfpaTinderContext>
    {
        protected override void Seed(AfpaTinderContext context)
        {
            IList<Personne> personnes = new List<Personne>();

            personnes.Add(new Personne() { Nom = "toto", Prenom = "titi", Email = "dfd", Login = "aa", Password = "test", Statut = true });
            personnes.Add(new Personne() { Nom = "marc", Prenom = "chanois", Email = "rrrr", Login = "bb", Password = "test2", Statut = true });

            context.Personnes.AddRange(personnes);

            context.SaveChanges();

            IList<Loisir> loisirs = new List<Loisir>();

            loisirs.Add(new Loisir() { Nom = "Sports" });
            loisirs.Add(new Loisir() { Nom = "Cinéma" });

            context.Loisirs.AddRange(loisirs);

            context.SaveChanges();

            IList<Ville> villes = new List<Ville>();

            villes.Add(new Ville() { Nom = "Paris", CodePostal = "75000" });
            villes.Add(new Ville() { Nom = "Montpellier", CodePostal = "34000" });

            context.Villes.AddRange(villes);

            context.SaveChanges();

        }
    }
}