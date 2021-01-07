import React from "react";
import { Link } from 'react-router-dom';
import { Formik } from "formik";
import * as Yup from "yup";
const Registration = () => (
  <Formik
    initialValues={{ username: "", email: "", password: "" }}
    onSubmit={(values, { setSubmitting }) => {
      setTimeout(() => {
        console.log("Registering", values);
        setSubmitting(false);
      }, 500);
    }}

    validationSchema={Yup.object().shape({
      username: Yup.string()
        .required("Username required")
        .min(5, "Username is too short, must be at least 5 characters"),
      email: Yup.string()
        .email("Email invalid. Please enter a valid email")
        .required("Email required"),
      password: Yup.string()
        .required("Password required")
        .min(5, "Password is too short, must be at least 5 characters")
        .matches(/(?=.*[0-9])/, "Password must contain a number."),
      Cpassword: Yup.string()
        .required("Please confirm password")
        .oneOf([Yup.ref('password'), null], "Passwords do not match, please try again")
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
        <form onSubmit={handleSubmit}>
          <label htmlFor="username">Username</label>
          <input
            name="username"
            type="text"
            placeholder="Enter your username"
            value={values.username}
            onChange={handleChange}
            onBlur={handleBlur}
            className={errors.username && touched.username && "error"}
          />
          {errors.username && touched.username && (
            <div className="input-feedback">{errors.username}</div>
          )}
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
          <label htmlFor="password">Password</label>
          <input
            name="password"
            type="password"
            placeholder="Enter your password"
            value={values.password}
            onChange={handleChange}
            onBlur={handleBlur}
            className={errors.password && touched.password && "error"}
          />
          {errors.password && touched.password && (
            <div className="input-feedback">{errors.password}</div>
          )}
           <label htmlFor="Cpassword">Confirm Password</label>
          <input
            name="Cpassword"
            type="password"
            placeholder="Please confirm password"
            value={values.Cpassword}
            onChange={handleChange}
            onBlur={handleBlur}
            className={errors.Cpassword && touched.Cpassword && "error"}
          />
          {errors.Cpassword && touched.Cpassword && (
            <div className="input-feedback">{errors.Cpassword}</div>
          )}
          <button type="submit" disabled={isSubmitting}>
            Register
          </button>
          <Link to="/login" className="btn btn-link">Login</Link>
        </form>
      );
    }}
  </Formik>
);

export default Registration;
