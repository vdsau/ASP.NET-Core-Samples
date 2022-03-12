using System;

using Transport_Data_Access_Layer.Helpers;
using Transport_Data_Access_Layer.Models.Common;
using Transport_Data_Access_Layer.Models.Deliver.Carriage;

namespace Transport_Data_Access_Layer.Models.Deliver.Driver
{

    /// <summary>
    /// Відомості про водія
    /// </summary>
    public class Driver : Notifier, ICloneable
    {

        #region Properties

        /// <summary>
        /// Контактні дані водія
        /// </summary>
        public ContactInfo About
        {
            get => Get<ContactInfo>();
            set => Set(value);
        }

        /// <summary>
        /// Вантажний транспорт 
        /// закріплений за водієм
        /// </summary>
        public ICarriage Carriage
        {
            get => Get<ICarriage>();
            set => Set(value);
        }

        #endregion

        #region Constructors

        private Driver()
        {
        }

        #endregion

        #region Methods

        /// <summary>
        /// Шаблон "фабричний метод"
        /// </summary>
        /// <returns>
        /// Об'єкт водія
        /// </returns>
        public static Driver Hire(ContactInfo about, ICarriage carriage)
        {
            return new Driver()
            {
                About = about,
                Carriage = carriage,
            };
        }

        /// <summary>
        /// Інформація про водія
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{About}" +
                   $"{Environment.NewLine}" +
                   $"Закріплений вантажний транспорт:" +
                   $"{Environment.NewLine}" +
                   $"{Carriage}";
        }

        /// <summary>
        /// Створити копію водія
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return new Driver()
            {
                About = this.About,
                Carriage = this.Carriage,
            };
        }

        #endregion

    }
}
