
    // Email validation
    const emailInput = document.getElementById('email');
    const emailError = document.getElementById('email-error');

    emailInput.addEventListener('input', function() {
      if (!emailInput.checkValidity()) {
        emailError.textContent = 'Please enter a valid email address.';
      } else {
        emailError.textContent = '';
      }
    });

    // Phone number validation
    const mobileInput = document.getElementById('mobile');
    const mobileError = document.getElementById('mobile-error');
    const phoneRegex = /^\d{10}$/;

    mobileInput.addEventListener('input', function() {
      if (!phoneRegex.test(mobileInput.value)) {
        mobileError.textContent = 'Please enter a 10-digit phone number.';
      } else {
        mobileError.textContent = '';
      }
    });