using System;
using System.Collections.Generic;
using System.Text;

namespace NeoSoft.Infrastructure.EF.Models
{
    public abstract class PaginatedQuery
    {
        private int _page = 1;
        private int _pageSize = 25;

        public int SkipCount { get { return (Page - 1) * PageSize; } }

        public int Page
        {
            get { return _page; }

            set
            {
                if (value < 1)
                {
                    throw new InvalidOperationException("Page must be a positive, non-zero int.");
                }

                _page = value;
            }
        }

        public int PageSize
        {
            get { return _pageSize; }

            set
            {
                if (value < 1)
                {
                    throw new InvalidOperationException("Page size must be a positive, non-zero int.");
                }

                _pageSize = value;
            }
        }
    }






}
