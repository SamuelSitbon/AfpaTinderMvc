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
            personnes.Add(new Personne() { Nom = "toto", Prenom = "titi", Email="dfd", Login="aa", Password="test", Status=true});
            personnes.Add(new Personne() { Nom = "marc", Prenom = "chanois", Email = "rrrr", Login = "bb", Password = "test", Status = true });

            context.Personnes.AddRange(personnes);

            base.Seed(context);
        }
    }
}