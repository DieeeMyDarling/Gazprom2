//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gazprom2.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class MaintenanceOfGasEquipment
    {
        public int id { get; set; }
        public Nullable<int> idUser { get; set; }
        public Nullable<int> idApplicationStatus { get; set; }
        public Nullable<int> idGasEquipment { get; set; }
        public string Adress { get; set; }
    
        public virtual ApplicationStatus ApplicationStatus { get; set; }
        public virtual GasEquipment GasEquipment { get; set; }
        public virtual User User { get; set; }
    }
}
