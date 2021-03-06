﻿namespace CommonQuery.NetCore.Builder
{
    /// <summary>
    ///     Class BaseQueryBuilder.
    /// </summary>
    public class BaseQueryBuilder : SearchCondition
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseQueryBuilder"/> class.
        /// </summary>
        public BaseQueryBuilder()
        {
            this._pageSize = 10;
            this.NeedPaging = false;
        }
        /// <summary>
        ///     Gets or sets a value indicating whether [default sort].
        /// </summary>
        /// <value><c>true</c> if [default sort]; otherwise, <c>false</c>.</value>
        public bool DefaultSort { get; set; }

        /// <summary>
        ///     Gets or sets the index of the page.
        /// </summary>
        /// <value>The index of the page.</value>
        public int PageIndex { get; set; }

        private int _pageSize;
        /// <summary>
        /// Gets or sets the size of the page.(Default value 10)
        /// </summary>
        /// <value>The size of the page.</value>
        public int PageSize {
            get { return this._pageSize; }
            set
            {
                if (value == 0)
                {
                    value = 10;
                }
                this._pageSize = value;
            }
        }
       
       

        /// <summary>
        ///     Gets or sets the sort field.
        /// </summary>
        /// <value>The sort field.</value>
        public string SortField { get; set; }

        /// <summary>
        ///     'asc' or 'desc'
        /// </summary>
        /// <value>The sort order.</value>
        public string SortOrder { get; set; }

        /// <summary>
        ///     Gets or sets the totol count.
        /// </summary>
        /// <value>The totol count.</value>
        public int TotolCount { get; set; }


        /// <summary>
        /// Gets or sets  needPaging 
        /// </summary>
        /// <value><c>true</c> if [need paging]; otherwise, <c>false</c>.</value>
        public bool NeedPaging { get; set; }

        /// <summary>
        ///     Sets the sort.
        /// </summary>
        /// <param name="sortField">The sort field.</param>
        /// <param name="sortOrder">The sort order.</param>
        public void SetSort(string sortField, string sortOrder)
        {
            if (this.DefaultSort)
            {
                this.SortField = sortField;
                this.SortOrder = sortOrder;
            }
        }
    }
}