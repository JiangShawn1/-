namespace 專題.Models.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AutoReply
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AutoReply()
        {
            AutoReplyKeyWords = new HashSet<AutoReplyKeyWord>();
            ChatRoomAutoReplies = new HashSet<ChatRoomAutoReply>();
        }
		[DisplayName("聊天室")]
		public int Id { get; set; }

        [Required]
        [StringLength(1000)]
        [DisplayName("自動回覆內容")]
        public string AutoReplyContent { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AutoReplyKeyWord> AutoReplyKeyWords { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChatRoomAutoReply> ChatRoomAutoReplies { get; set; }
    }
}
