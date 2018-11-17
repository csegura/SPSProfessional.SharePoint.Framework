using System.Collections;
using System.Collections.Generic;

namespace SPSProfessional.SharePoint.Framework.Hierarchy
{
    /// <summary>
    /// Walk delegate
    /// </summary>
    //public delegate void SPSHierarchyIteratorFunc(ISPSTreeNode<ISPSHierarchyNode> node, int deep);
    public delegate void SPSHierarchyIteratorFunc(ISPSHierarchyNode node, int deep);

    /// <summary>
    /// Hierarchy Iterator
    /// </summary>
    public class SPSHierarchyIterator : IEnumerable<ISPSHierarchyNode>
    {
        private int _deep;
        private readonly SPSHierarchyDataSource _dataSource;
        
        /// <summary>
        /// Initializes a new instance of the <see cref="SPSHierarchyIterator"/> class.
        /// </summary>
        /// <param name="dataSource">The data source.</param>
        public SPSHierarchyIterator(SPSHierarchyDataSource dataSource)
        {
            _dataSource = dataSource;
        }

        /// <summary>
        /// Iterators the recursive.
        /// </summary>
        /// <param name="root">The root.</param>
        /// <param name="iteratorFunc">The iterator func.</param>
        public void IteratorRecursive(ISPSTreeNode<ISPSHierarchyNode> root, SPSHierarchyIteratorFunc iteratorFunc)
        {
            _deep = 0;
            IteratorRecursiveInternal(root,iteratorFunc);
        }

        private void IteratorRecursiveInternal(ISPSTreeNode<ISPSHierarchyNode> root, SPSHierarchyIteratorFunc iteratorFunc)
        {
            if (iteratorFunc != null)
            {
                iteratorFunc(root.Node, _deep);
            }
           
            _deep++;
            foreach (ISPSTreeNode<ISPSHierarchyNode> node in root.Children)
            {
                IteratorRecursiveInternal(node,iteratorFunc);
            }
            _deep--;
        }

        #region Implementation of IEnumerable

        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Collections.Generic.IEnumerator`1"/> that can be used to iterate through the collection.
        /// </returns>
        public IEnumerator<ISPSHierarchyNode> GetEnumerator()
        {
            _deep = 0;
            List<ISPSHierarchyNode> listNodes = new List<ISPSHierarchyNode>();
            IteratorRecursiveInternal(_dataSource.Root, (node,deep) => listNodes.Add(node));
            return listNodes.GetEnumerator();
        }

        /// <summary>
        /// Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>
        /// An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the collection.
        /// </returns>
        /// <filterpriority>2</filterpriority>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion
    }
}
