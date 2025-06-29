# Bone Selection VR Simulation – Unity + Meta Quest

This Unity project is a VR-based bone selection simulation created for Meta Quest headsets. The player is placed in a virtual room where three bones are laid out on a table. The goal is to choose the correct bone — the one that appears directly in front of the player — using a laser pointer from the controller.

## Features
Designed for Meta Quest with VR support

Bone selection using laser pointer via controller

Simple interactive simulation for educational or gamified environments

Custom scene and logic using Unity XR Toolkit

## How to Run

Open the project in Unity Hub

Use Unity Editor version matching your setup (e.g. 2022.x.x)

Open the scene: Assets/Scenes/bone unfinished.unity

Connect your Meta Quest headset via Link or Air Link

Press Play to test in editor, or build for the headset

## Requirements

Unity with XR Plugin Management and Meta Quest integration

Meta Quest headset + USB-C or wireless connection

Windows OS

## Folder Structure

Assets/

├── Scenes/ → Contains the main VR scene

├── Scripts/ → Logic for bone selection and interaction

├── XR/, Samples/, XRI/ → XR and input configuration

├── [others, as needed]

## Notes

This project excludes Library/, Temp/, Build/, etc. from Git (see .gitignore)

Laser pointer works based on XR Ray Interactor and collision detection

Author
Created by MViksna03
