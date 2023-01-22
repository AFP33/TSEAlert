using System.Collections.Generic;

namespace TSEAlert.Handler
{
    public interface IXmlHandler<T>
    {
        /// <summary>
        /// Get all items
        /// </summary>
        /// <returns></returns>
        List<T> Get();

        /// <summary>
        /// Get specific item
        /// </summary>
        /// <param name="id">Specific item</param>
        /// <returns></returns>
        T Get(int id);

        /// <summary>
        /// Add new item
        /// </summary>
        /// <param name="obj">item</param>
        /// <returns></returns>
        int Add(T obj);

        /// <summary>
        /// update specific item
        /// </summary>
        /// <param name="obj">item</param>
        /// <returns></returns>
        bool Update(T obj);

        /// <summary>
        /// Remove specific item
        /// </summary>
        /// <param name="obj">item</param>
        /// <returns></returns>
        bool Remove(T obj);

        /// <summary>
        /// Remove range of items
        /// </summary>
        /// <param name="objs">items</param>
        /// <returns></returns>
        bool Remove(List<T> objs);

        /// <summary>
        /// Remove all items
        /// </summary>
        /// <returns></returns>
        bool RemoveAll();
    }
}
