using System;

namespace MyService.API
{
    /// <summary>
    /// My class and docs for use it
    /// </summary>
    /// <code>
    /// var service = Factory.GetService();
    /// </code>
    public interface IService
    {
        /// <summary>
        /// Return answer for everything
        /// </summary>
        /// <returns>42</returns>
        string GetAnswer();

        /// <summary>
        /// My description
        /// </summary>
        /// <returns></returns>
        int GetInt();

        /// <summary>
        /// > [!WARNING]
        /// > Obsoleted
        /// 
        /// It's obsolete. Use <see cref="GetDecimal"/> instead
        /// My description for GetDouble
        /// </summary>
        /// <returns></returns>
        [Obsolete]
        double GetDouble();

        /// <summary>
        /// My description for GetDecimal
        /// </summary>
        /// <returns></returns>
        decimal GetDecimal();
    }
}
