using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursCsharp.BanApi.Api.Model
{
    /// <summary>
    /// Caractéristique
    /// </summary>
    public class Feature
    {
        #region Attributes
        
        /// <summary>
        /// Type
        /// </summary>
        private string _Type;
        /// <summary>
        /// Objet géometrique
        /// </summary>
        private Geometry _Geometry;
        /// <summary>
        /// Propriétés
        /// </summary>
        private Properties _Properties;

        #endregion

        #region Properties

        /// <summary>
        /// Obtient ou défini la Type
        /// </summary>
        public string Type { get => _Type; set => _Type = value; }

        /// <summary>
        /// Obtient ou défini l'objet géométrique
        /// </summary>
        public Geometry Geometry { get => _Geometry; set => _Geometry = value; }

        /// <summary>
        /// Obtient ou défini la Propriété
        /// </summary>
        public Properties Properties { get => _Properties; set => _Properties = value; }

        #endregion

        #region Methods

        /// <summary>
        /// Liste les propriétés de la caractéristique
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "N° : " + this.Properties.HouseNumber + Environment.NewLine +
                "Nom : " + this.Properties.Name + Environment.NewLine +
                "CP : " + this.Properties.PostCode + Environment.NewLine +
                "Ville : " + this.Properties.City + Environment.NewLine +
                "Rue : " + this.Properties.Street + Environment.NewLine +
                "Type : " + this.Properties.Type + Environment.NewLine;
        }

        #endregion
    }
}
