using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursCsharp.BanApi.Api.Model
{

    /// <summary>
    /// Résultat d'une requête à l'API BAN
    /// </summary>
    public class BanResult
    {
        #region Attributes

        /// <summary>
        /// Licence
        /// </summary>
        private string _Licence;

        /// <summary>
        /// Liste des caractéristiques
        /// </summary>
        private List<Feature> _Features;

        /// <summary>
        /// Limite
        /// </summary>
        private int _Limit;

        /// <summary>
        /// Version
        /// </summary>
        private string _Version;

        /// <summary>
        /// Attribution
        /// </summary>
        private string _Attribution;

        /// <summary>
        /// Type
        /// </summary>
        private string _Type;

        /// <summary>
        /// Requête
        /// </summary>
        private string _Query;

        #endregion

        #region Properties

        /// <summary>
        /// Obtient ou définit la licence
        /// </summary>
        public string Licence { get => _Licence; set => _Licence = value; }

        /// <summary>
        /// Obtient ou défini la limite
        /// </summary>
        public int Limit { get => _Limit; set => _Limit = value; }

        /// <summary>
        /// Obtient ou défini la version
        /// </summary>
        public string Version { get => _Version; set => _Version = value; }

        /// <summary>
        /// Obtient ou défini l'attribution
        /// </summary>
        public string Attribution { get => _Attribution; set => _Attribution = value; }
        
        /// <summary>
        /// Obtient ou défini le type
        /// </summary>
        public string Type { get => _Type; set => _Type = value; }

        /// <summary>
        /// Obtient ou défini la requête
        /// </summary>
        public string Query { get => _Query; set => _Query = value; }

        /// <summary>
        /// Obitent ou défini la liste des caractéristiques
        /// </summary>
        public List<Feature> Features { get => _Features; set => _Features = value; }

        #endregion
    }
}
