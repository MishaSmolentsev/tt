//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Amonic
{
    using System;
    using System.Collections.Generic;
    
    public partial class trecking
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public Nullable<System.DateTime> Enter_date { get; set; }
        public Nullable<System.TimeSpan> Enter_time { get; set; }
        public Nullable<System.DateTime> Logout_date { get; set; }
        public Nullable<System.TimeSpan> Logout_time { get; set; }
        public string Crash_report { get; set; }
        public string Crash_type { get; set; }
        public int Id_user { get; set; }
    
        public virtual Users Users { get; set; }
    }
}