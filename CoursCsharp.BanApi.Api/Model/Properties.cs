using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursCsharp.BanApi.Api.Model
{
    public class Properties
    {
        #region Attributes

        /// <summary>
        /// Contexte
        /// </summary>
        private string _Context;

        /// <summary>
        /// Libellé
        /// </summary>
        private string _Label;

        /// <summary>
        /// Score
        /// </summary>
        private string _Score;

        /// <summary>
        /// Numéro de rue
        /// </summary>
        private string _HouseNumber;

        /// <summary>
        /// Identifiant
        /// </summary>
        private string _Id;

        /// <summary>
        /// Type 
        /// </summary>
        private string _Type;

        /// <summary>
        /// Name
        /// </summary>
        private string _Name;

        /// <summary>
        /// Code Postal
        /// </summary>
        private string _PostCode;

        /// <summary>
        /// Code ville
        /// </summary>
        private string _CityCode;

        /// <summary>
        /// Position X
        /// </summary>
        private decimal _X;

        /// <summary>
        /// Position Y
        /// </summary>
        private decimal _Y;

        /// <summary>
        /// 
        /// </summary>
        private string _City;

        /// <summary>
        /// Importance
        /// </summary>
        private double _Importance;

        /// <summary>
        /// Rue
        /// </summary>
        private string _Street;

        #endregion

        #region Properties
        /// <summary>
        /// Obtient ou défini le Label
        /// </summary>
        public string Label { get => _Label; set => _Label = value; }
        /// <summary>
        /// Obtient ou défini le score
        /// </summary>
        public string Score { get => _Score; set => _Score = value; }

        /// <summary>
        /// Obtient ou défini le Numéro
        /// </summary>
        public string HouseNumber { get => _HouseNumber; set => _HouseNumber = value; }

        /// <summary>
        /// Obtient ou défini l'identifiant
        /// </summary>
        public string Id { get => _Id; set => _Id = value; }

        /// <summary>
        /// Obtient ou défini le type
        /// </summary>
        public string Type { get => _Type; set => _Type = value; }
        /// <summary>
        /// Obtient ou défini le Nom
        /// </summary>
        public string Name { get => _Name; set => _Name = value; }

        /// <summary>
        /// Obtient ou défini le code postal
        /// </summary>
        public string PostCode { get => _PostCode; set => _PostCode = value; }

        /// <summary>
        /// Obtient ou défini le code de la ville
        /// </summary>
        public string CityCode { get => _CityCode; set => _CityCode = value; }

        /// <summary>
        /// Obtient ou défini X
        /// </summary>
        public decimal X { get => _X; set => _X = value; }
        /// <summary>
        /// Obtient ou défini Y
        /// </summary>
        public decimal Y { get => _Y; set => _Y = value; }

        /// <summary>
        /// Obtient ou défini la ville
        /// </summary>
        public string City { get => _City; set => _City = value; }
        /// <summary>
        /// Obtient ou défini l'importance
        /// </summary>
        public double Importance { get => _Importance; set => _Importance = value; }
        /// <summary>
        /// Obtient ou défini La rue
        /// </summary>
        public string Street { get => _Street; set => _Street = value; }

        #endregion

    }
}
