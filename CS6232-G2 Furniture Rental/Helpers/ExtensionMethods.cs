﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CS6232_G2_Furniture_Rental.Helpers
{
    /// <summary>
    /// This is a helper class that I made to hold extension methods.
    /// </summary> 
    public static class ExtensionMethods
    {
        /// <summary>
        /// Hides the form that called this method, and finds an instance of the form that this is called for.
        ///
        /// If the instance exists, shows it, and if it doesn't then it makes a new one and shows it.
        /// </summary>
        /// <typeparam name="T">The type of form that should be shown</typeparam>
        /// <param name="thisForm">The form that is calling this method. Will be hidden.</param>
        /// <returns>the new form that was just shown - in case we need to do anything with it.</returns>
        public static T HideThisAndShowForm<T>(this Form thisForm) where T : Form, new()
        {
            var otherForm = RetrieveOrCreateForm<T>();
            otherForm.Show();
            thisForm.Hide();
            return otherForm;
        }

        /// <summary>
        /// Finds an instance of the form that this is called for and shows it as a dialog.
        /// 
        /// If the instance exists, shows it, and if it doesn't then it makes a new one and shows it.
        /// </summary>
        /// <typeparam name="T">The type of form that should be shown</typeparam>
        /// <param name="thisForm">The form that is calling this method.</param>
        /// <param name="setupAction">the action to take before showing the dialog</param>
        /// <returns>the new form that was just shown - in case we need to do anything with it.</returns>
        public static T ShowFormAsDialog<T>(this Form thisForm, Action<T> setupAction = null) where T : Form, new()
        {
            var otherForm = RetrieveOrCreateForm<T>();
            setupAction?.Invoke(otherForm);
            otherForm.ShowDialog(thisForm);
            return otherForm;
        }

        /// <summary>
        /// This keeps us from ever having more than one copy of any given form open. If one exists it returns it, and if one doesn't then it makes a new one.
        /// </summary>
        /// <typeparam name="T">The form that we are finding/opening</typeparam>
        /// <returns>the matching form</returns>
        private static T RetrieveOrCreateForm<T>() where T : Form, new()
        {
            return Application.OpenForms.Cast<Form>()
                     .FirstOrDefault(c => c is T) as T ?? new T();
        }

        /// <summary>
        /// Retrieves a list of controls of type T on the current form, allowing properties like 'enabled' to be set on them as a group
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="control"></param>
        /// <returns>a list of form controls of type T</returns>
        public static IEnumerable<T> GetChildControls<T>(this Control control) where T : Control
        {
            var children = control.Controls.OfType<T>();
            var enumerable = children as T[] ?? children.ToArray();
            return enumerable.SelectMany(GetChildControls<T>).Concat(enumerable);
        }
    }
}
