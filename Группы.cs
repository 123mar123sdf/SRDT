//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Расписание_занятий
{
    using System;
    using System.Collections.Generic;
    
    public partial class Группы
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Группы()
        {
            this.Расписание_вторник = new HashSet<Расписание_вторник>();
            this.Расписание_понедельник = new HashSet<Расписание_понедельник>();
            this.Расписание_пятница = new HashSet<Расписание_пятница>();
            this.Расписание_среда = new HashSet<Расписание_среда>();
            this.Расписание_четверг = new HashSet<Расписание_четверг>();
        }
    
        public int ID_Группы { get; set; }
        public Nullable<int> ID_Объединения { get; set; }
        public string Название_группы { get; set; }
        public Nullable<int> Количество_учеников { get; set; }
    
        public virtual Объединения Объединения { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Расписание_вторник> Расписание_вторник { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Расписание_понедельник> Расписание_понедельник { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Расписание_пятница> Расписание_пятница { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Расписание_среда> Расписание_среда { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Расписание_четверг> Расписание_четверг { get; set; }
    }
}
