export function scrollToSection(sectionId) {
    const section = document.getElementById(sectionId);

    // Scroll smoothly to the section
    section.scrollIntoView({ behavior: 'smooth' });
}

export function showPrompt(message) {
  return prompt(message, 'Type anything here');
}

