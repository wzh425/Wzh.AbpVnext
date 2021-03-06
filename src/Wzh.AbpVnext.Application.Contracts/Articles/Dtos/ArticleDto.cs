using EasyAbp.Abp.DataDictionary;
using System;
using Volo.Abp.Application.Dtos;

namespace Wzh.AbpVnext.Articles.Dtos
{
    [Serializable]
    public class ArticleDto : AuditedEntityDto<Guid>
    {
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 外链
        /// </summary>
        public string LinkUrl { get; set; }
        /// <summary>
        /// 封面图
        /// </summary>
        public Guid? ImgId { get; set; }
        /// <summary>
        /// 标签
        /// </summary>
        public string Tags { get; set; }
        /// <summary>
        /// 摘要
        /// </summary>
        public string ZhaiYao { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 浏览次数
        /// </summary>
        public int? ViewCount { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int DisplayOrder { get; set; }
        /// <summary>
        /// 分类ID
        /// </summary>
        public Guid CategoryId { get; set; }

        public ArticleCategoryDto Category { get; set; }
        /// <summary>
        /// 文章类型
        /// </summary>
        [DictionaryCodeField("ArticleType")]
        [DictionaryRenderField("ArticleType")]
        public string Type { get; set; }
    }
}