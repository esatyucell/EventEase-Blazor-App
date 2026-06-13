# 🎉 EventEase | Blazor WebAssembly Application

> **🎓 Certification Project:** This application was designed and developed as a comprehensive project for the **Microsoft Fullstack Developer Professional Certificate**.

## 🌐 Overview
**EventEase** is a modern Single Page Application (SPA) built using **Blazor WebAssembly** and **C#**. It serves as an interactive event management and ticketing dashboard. This project demonstrates advanced .NET ecosystem capabilities, moving beyond static pages to deliver a fully functional, state-driven user experience without relying on traditional JavaScript.

## ✨ Key Features & Technical Highlights

This project successfully implements all core requirements of the capstone rubric:

- **🧩 Component-Driven Architecture:** Features a reusable foundational `EventCard.razor` component that efficiently renders dynamic event data.
- **🔄 Two-Way Data Binding:** Demonstrates real-time UI updates using Blazor's `@bind` and `@bind:event="oninput"` directives for user-specific quick notes.
- **🗺️ Advanced Routing & Error Handling:** Utilizes Blazor's built-in router with a custom `<NotFound>` layout to safely catch and redirect invalid URLs, preventing application crashes.
- **🛡️ Form Validation:** Implements strict data validation on the Registration Form using C# `[DataAnnotations]`, ensuring secure and formatted user inputs (e.g., Email formats, required fields).
- **💾 Global State Management:** Features a custom injected `SessionStateService` to maintain user login sessions and track RSVPs (Attendance Tracker) across different pages without losing state.
- **🤖 AI-Assisted Development:** Developed alongside Microsoft Copilot to optimize boilerplate code, debug routing loops, and generate robust C# models. *(See `COPILOT_SUMMARY.md` for details).*

## 🛠️ Technology Stack

- **Framework:** .NET Core / Blazor WebAssembly
- **Language:** C# 
- **Styling:** CSS3 & Bootstrap 5
- **Tooling:** Microsoft Copilot, Visual Studio Code / Visual Studio

## 🚀 How to Run Locally

To run this project on your local machine, ensure you have the [.NET SDK](https://dotnet.microsoft.com/download) installed.

1. Clone the repository:
```bash
   git clone [https://github.com/esatyucell/EventEase-Blazor-App.git](https://github.com/esatyucell/EventEase-Blazor-App.git)