import React, { Component } from 'react';
import { Link } from 'react-router-dom';
import { Formik } from "formik";
import * as Yup from "yup";
const Counter = () => (
  <Formik
    initialValues={{ email: "", password: ""}}
    onSubmit={(values, { setSubmitting }) => {
      setTimeout(() => {
        console.log("Registering", values);
        setSubmitting(false);
      }, 500);
    }}

    validationSchema={Yup.object().shape({
      email: Yup.string()
        .email("Email invalid. Please enter a valid email")
        .required("Email required"),
      password: Yup.string()
        .required("Password required")
        .min(5, "Password is too short, must be at least 5 characters")
        .matches(/(?=.*[0-9])/, "Password must contain a number.")
    })}
  >
    {props => {
      const {
        values,
        touched,
        errors,
        isSubmitting,
        handleChange,
        handleBlur,
        handleSubmit
      } = props;
      return (
        <main>
        <form onSubmit={handleSubmit}>
          <div>
            <span className="headline-text">Change Password</span>
            <p>Please enter your email and new password</p>
          </div>
          <label htmlFor="email">Email</label>
          <input
            name="email"
            type="text"
            placeholder="Enter your email"
            value={values.email}
            onChange={handleChange}
            onBlur={handleBlur}
            className={errors.email && touched.email && "error"}
          />
          {errors.email && touched.email && (
            <div className="input-feedback">{errors.email}</div>
          )}
          <label htmlFor="password">New Password</label>
          <input
            name="password"
            type="password"
            placeholder="Enter your new password"
            value={values.password}
            onChange={handleChange}
            onBlur={handleBlur}
            className={errors.password && touched.password && "error"}
          />
          {errors.password && touched.password && (
            <div className="input-feedback">{errors.password}</div>
          )}
          <button type="submit" disabled={isSubmitting}>
            Change password
          </button>
        </form>
        <div class="spacing"></div>
        <div class="newdiv">
        <span className="headline-text">Delete account</span>
        </div>
        <div class="newdiv">
        <button className="deletebutton" disabled={isSubmitting}>
            Delete Account
          </button>
          </div>
      </main>
      );
    }}
  </Formik>
);

export default Counter;