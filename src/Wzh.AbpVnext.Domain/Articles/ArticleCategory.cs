using EasyAbp.Abp.Trees;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Wzh.AbpVnext.Articles
{
 
    public class ArticleCategory : FullAuditedAggregateRoot<Guid>, ITree<ArticleCategory>, IMultiTenant
    {
        public ArticleCategory(Guid id)
            : base(id)
        {
            Children = new List<ArticleCategory>();
        }
        /// <summary>
        /// 名称
        /// </summary>
        [StringLength(100)]
        public virtual string DisplayName { get; set; }
        /// <summary>
        /// 调用码
        /// </summary>
        [StringLength(100)]
        public virtual string Code { get; set; }
        /// <summary>
        /// 级别
        /// </summary>
        public virtual int Level { get; set; }
        /// <summary>
        /// 父级
        /// </summary>
        public virtual ArticleCategory Parent { get; set; }
        /// <summary>
        /// 父级Id
        /// </summary>
        public virtual Guid? ParentId { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        [Display(Name = "排序")]
        public int DisplayOrder { get; set; }
        /// <summary>
        /// 子项
        /// </summary>
        public virtual ICollection<ArticleCategory> Children { get; set; }

        public Guid? TenantId { get; set; }
        [Display(Name = "图标")]
        public Guid? IconId { get; set; }
        protected ArticleCategory()
        {
        }

        public ArticleCategory(
            Guid id,
            string displayName,
            string code,
            int level,
            ArticleCategory parent,
            Guid? parentId,
            ICollection<ArticleCategory> children
        ) : base(id)
        {
            DisplayName = displayName;
            Code = code;
            Level = level;
            Parent = parent;
            ParentId = parentId;
            Children = children;
        }
    }
}
