using Hymma.ERP;
using System.Drawing;

namespace Hymma.ERP.Core
{
    /// <summary>
    /// a component that needs to be registered in a vault or data management system
    /// </summary>
    public interface IDocumentable :IHaveTableInDb
    {
        /// <summary>
        /// file name on HDD with extensions
        /// </summary>
        string FileName { get;  }

        /// <summary>
        /// full file name including directory
        /// </summary>
        string FullFileName { get; }

        /// <summary>
        /// short description for this <see cref="IDocumentable"/>
        /// </summary>
        string Description { get;  }

        /// <summary>
        /// long description for this <see cref="IDocumentable"/>
        /// </summary>
        string LongDescription { get;  }

        /// <summary>
        /// friendly name as people refer to it
        /// </summary>
        string DisplayName { get;  }
        /// <summary>
        /// revision of this <see cref="IDocumentable"/>
        /// </summary>
        string Revision { get;  }

        /// <summary>
        /// a thumbnail for this <see cref="IDocumentable"/>
        /// </summary>
        Bitmap Thumbnail { get;  }

        /// <summary>
        /// id or part no of this component
        /// </summary>
        string PartNo { get;  }

    }
}
