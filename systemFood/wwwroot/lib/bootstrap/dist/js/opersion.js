
        //// Generate a random order ID
        //document.getElementById('order-id').textContent = Math.floor(100000 + Math.random() * 900000);

       

       
        //const taxRate = 0.10; // 10% tax
        //const serviceCharge = 0; // Fixed service charge, can be dynamic

       




        //// Current language setting
        //let currentLanguage = 'ar'; // Default to Arabic

        //// Last updated timestamp for notifications/data freshness
        //let lastUpdated = new Date().toLocaleString('ar-SA');


        //// Function to display messages (reusing existing messagebox)
        //function showMessageBox(message) {
        //    const messageBox = document.createElement('div');
        //    messageBox.className = 'fixed inset-0 bg-black bg-opacity-50 flex items-center justify-center z-50';
        //    messageBox.innerHTML = `
        //        <div class="bg-white p-6 rounded-lg shadow-xl text-center">
        //            <p class="text-xl font-semibold mb-4">${message}</p>
        //            <button class="bg-blue-600 text-white px-4 py-2 rounded-lg hover:bg-blue-700 transition-colors duration-200" onclick="this.closest('.fixed').remove()">موافق</button>
        //        </div>
        //    `;
        //    document.body.appendChild(messageBox);
        //}

        //// Function to render category buttons in a given container
        //function renderCategoryButtons(container, isManagementView = false) {
        //    container.innerHTML = ''; // Clear existing buttons
        //    categories.forEach(cat => {
        //        const buttonClass = cat.active ? 'bg-blue-600 text-white' : 'bg-gray-100 text-gray-700 hover:bg-gray-200';
        //        // Define Arabic translations for common categories
        //        const categoryTranslations = {
        //            'All Items': 'جميع الأصناف',
        //            'Pizza': 'بيتزا',
        //            'Pasta': 'باستا',
        //            'Offers': 'عروض',
        //            'Fast Food': 'وجبات سريعة',
        //            'Drinks': 'مشروبات',
        //            'Salads': 'سلطات',
        //            'Desserts': 'حلويات'
        //        };
        //        const categoryText = categoryTranslations[cat.name] || cat.name; // Use translation or original name

        //        const buttonHtml = `
        //            <button class="flex-shrink-0 flex flex-col items-center justify-center p-3 w-28 h-28 rounded-2xl shadow-md ${buttonClass}" data-category-name="${cat.name}">
        //                <i class="${cat.icon} text-2xl mb-2"></i>
        //                <span>${categoryText}</span>
        //            </button>
        //        `;
        //        container.insertAdjacentHTML('beforeend', buttonHtml);
        //    });

        //    if (isManagementView) {
        //        // Add the "Add Category" button if in product management view
        //        const addCategoryButtonHtml = `
        //            <button id="add-category-button" class="flex-shrink-0 flex items-center justify-center p-3 w-28 h-28 bg-gray-50 text-gray-400 rounded-2xl shadow-md border-dashed border-2 cursor-pointer hover:bg-gray-100 transition-colors duration-200">
        //                <i class="fas fa-plus text-4xl mb-4"></i>
        //                <span class="text-xl font-semibold">فئة</span>
        //            </button>
        //        `;
        //        container.insertAdjacentHTML('beforeend', addCategoryButtonHtml);
        //        // Re-attach listener for the newly added button
        //        document.getElementById('add-category-button').addEventListener('click', () => {
        //            resetAddCategoryModal(); // Ensure modal is clean
        //            addCategoryModal.style.display = 'flex';
        //        });
        //    }
        //}


        ////// Function to render products in cashier view
        ////function renderProducts() {
        ////    productDisplayArea.innerHTML = ''; // Clear existing products
        ////    products.forEach(product => {
        ////        const productCardHtml = `
        ////            <div class="product-card bg-white p-4 rounded-xl shadow-md border border-gray-200 flex flex-col items-center text-center cursor-pointer hover:shadow-lg transition-shadow duration-200"
        ////                data-name="${product.name}" data-price="${product.basePrice}" data-description="${product.description}" data-image="${product.image}">
        ////                <img src="${product.image}" alt="${product.name}" class="w-24 h-24 rounded-full mb-3 object-cover">
        ////                <h3 class="font-semibold text-lg text-gray-800">${product.name}</h3>
        ////                <p class="text-gray-600 text-sm mb-2">${product.description}</p>
        ////                <p class="text-xl font-bold text-blue-600">${product.basePrice} EGP</p>
        ////                <div class="flex items-center space-x-2 mt-3 product-quantity-controls hidden">
        ////                    <button class="decrease-quantity bg-gray-200 text-gray-700 p-1 rounded-full w-6 h-6 flex items-center justify-center text-sm font-bold">-</button>
        ////                    <span class="quantity-display text-lg font-medium">1</span>
        ////                    <button class="increase-quantity bg-blue-500 text-white p-1 rounded-full w-6 h-6 flex items-center justify-center text-sm font-bold">+</button>
        ////                </div>
        ////            </div>
        ////        `;
        ////        productDisplayArea.insertAdjacentHTML('beforeend', productCardHtml);
        ////    });
        //    // Re-attach event listeners to new product cards
        ////    document.querySelectorAll('.product-card').forEach(card => {
        ////        card.addEventListener('click', (event) => {
        ////            if (!event.target.closest('.product-quantity-controls')) {
        ////                const name = card.dataset.name;
        ////                const price = card.dataset.price;
        ////                const image = card.dataset.image;
        ////                const description = card.dataset.description || '';
        ////                addItemToOrder(name, price, image, description);
        ////            }
        ////        });
        ////    });
        ////}

        //// Function to render products in product management view
        ////function renderProductManagementList() {
        ////    productManagementList.innerHTML = ''; // Clear existing list
        ////    // Add the "Add New Dish" card first
        ////    productManagementList.appendChild(addNewDishCard);

        ////    products.forEach(product => {
        ////        const productCardHtml = `
        ////            <div class="product-management-card bg-white p-4 rounded-xl shadow-md border border-gray-200 flex flex-col items-center text-center" data-product-id="${product.id}">
        ////                <img src="${product.image}" alt="${product.name}" class="w-24 h-24 rounded-full mb-3 object-cover">
        ////                <h3 class="font-semibold text-lg text-gray-800">${product.name}</h3>
        ////                <p class="text-gray-600 text-sm mb-2">${product.description}</p>
        ////                <p class="text-xl font-bold text-blue-600 mb-4">${product.basePrice} EGP</p>
        ////                <div class="flex space-x-2 w-full justify-center">
        ////                    <button class="edit-dish-button flex-1 bg-gray-100 text-blue-600 py-2 rounded-lg hover:bg-gray-200 transition-colors duration-200 flex items-center justify-center space-x-2" data-product-id="${product.id}">
        ////                        <i class="fas fa-edit"></i>
        ////                        <span>تعديل الأطباق</span>
        ////                    </button>
        ////                    <button class="delete-dish-button flex-1 bg-red-100 text-red-600 py-2 rounded-lg hover:bg-red-200 transition-colors duration-200 flex items-center justify-center space-x-2" data-product-id="${product.id}">
        ////                        <i class="fas fa-trash-alt"></i>
        ////                        <span>حذف</span>
        ////                    </button>
        ////                </div>
        ////            </div>
        ////        `;
        ////        productManagementList.insertAdjacentHTML('beforeend', productCardHtml);
        ////    });

        //    // Re-attach event listeners for edit and delete buttons
        ////    document.querySelectorAll('.edit-dish-button').forEach(button => {
        ////        button.addEventListener('click', (e) => {
        ////            const productId = e.currentTarget.dataset.productId;
        ////            openAddEditDishModal(productId);
        ////        });
        ////    });

        ////    document.querySelectorAll('.delete-dish-button').forEach(button => {
        ////        button.addEventListener('click', (e) => {
        ////            const productId = e.currentTarget.dataset.productId;
        ////            // Implement delete functionality here
        ////            deleteDish(productId);
        ////        });
        ////    });
        ////}


        //// Function to calculate individual item price including extras and size
        //function calculateItemPrice(item) {
        //    let itemBasePrice = item.basePrice;
        //    let extraCost = 0;
        //    item.extras.forEach(extra => {
        //        extraCost += extraOptionsData[extra] ? extraOptionsData[extra].price : 0;
        //    });
        //    let sizeMultiplier = sizeOptionsData[item.size] ? sizeOptionsData[item.size].multiplier : 1.0;
        //    return (itemBasePrice + extraCost) * sizeMultiplier;
        //}

        //// Function to render the order list and update totals
        //function renderOrder() {
        //    orderListElement.innerHTML = ''; // Clear existing list
        //    let currentSubtotal = 0;

        //    if (order.length === 0) {
        //        orderListElement.innerHTML = '<p class="text-center text-gray-500 py-4">لا توجد عناصر في الطلب بعد.</p>';
        //    }

        //    //order.forEach(item => {
        //    //    const itemCalculatedPrice = calculateItemPrice(item);
        //    //    const itemTotal = itemCalculatedPrice * item.quantity;
        //    //    currentSubtotal += itemTotal;

        //    //    const orderItemHtml = `
        //    //        <div class="flex items-center justify-between p-3 mb-3 bg-gray-50 rounded-lg cursor-pointer" data-id="${item.id}">
        //    //            <div class="flex items-center space-x-3 order-item-details">
        //    //                <img src="${item.image}" alt="${item.name}" class="w-10 h-10 rounded-lg">
        //    //                <div>
        //    //                    <p class="font-medium text-gray-800">${item.name}</p>
        //    //                    <p class="text-sm text-gray-500">${item.description || ''}</p>
        //    //                    ${item.extras.length > 0 ? `<p class="text-xs text-gray-400">إضافات: ${item.extras.map(e => extraOptionsData[e].name).join(', ')}</p>` : ''}
        //    //                    ${item.size !== 'm' ? `<p class="text-xs text-gray-400">الحجم: ${sizeOptionsData[item.size].name}</p>` : ''}
        //    //                    ${item.note ? `<p class="text-xs text-gray-400">ملاحظة: ${item.note}</p>` : ''}
        //    //                </div>
        //    //            </div>
        //    //            <div class="flex items-center space-x-3">
        //    //                <div class="flex items-center space-x-1">
        //    //                    <button class="decrease-order-quantity bg-gray-200 text-gray-700 p-1 rounded-full w-6 h-6 flex items-center justify-center text-sm font-bold">-</button>
        //    //                    <span class="order-quantity-display text-lg font-medium">${item.quantity}</span>
        //    //                    <button class="increase-order-quantity bg-blue-500 text-white p-1 rounded-full w-6 h-6 flex items-center justify-center text-sm font-bold">+</button>
        //    //                </div>
        //    //                <span class="text-gray-700">${itemTotal.toFixed(0)} EGP</span>
        //    //                <button class="remove-item text-red-500 hover:text-red-700" data-id="${item.id}">
        //    //                    <i class="fas fa-trash-alt"></i>
        //    //                </button>
        //    //            </div>
        //    //        </div>
        //    //    `;
        //    //    orderListElement.insertAdjacentHTML('beforeend', orderItemHtml);
        //    //});

        //    // Calculate totals
        ////    const calculatedTax = currentSubtotal * taxRate;
        ////    const calculatedTotal = currentSubtotal + calculatedTax + serviceCharge;

        ////    // Update DOM
        ////    itemsCountElement.textContent = order.reduce((sum, item) => sum + item.quantity, 0);
        ////    subtotalElement.textContent = `${currentSubtotal.toFixed(0)} EGP`;
        ////    taxElement.textContent = `${calculatedTax.toFixed(0)} EGP`;
        ////    serviceChargeElement.textContent = `${serviceCharge.toFixed(0)} EGP`;
        ////    totalElement.textContent = `${calculatedTotal.toFixed(0)} EGP`;

        ////    // Attach event listeners to new elements (increase/decrease/remove/edit buttons)
        ////    document.querySelectorAll('.remove-item').forEach(button => {
        ////        button.onclick = (e) => removeItem(e.currentTarget.dataset.id);
        ////    });
        ////    document.querySelectorAll('.increase-order-quantity').forEach(button => {
        ////        button.onclick = (e) => updateOrderItemQuantity(e.currentTarget.dataset.id, 1);
        ////    });
        ////    document.querySelectorAll('.decrease-order-quantity').forEach(button => {
        ////        button.onclick = (e) => updateOrderItemQuantity(e.currentTarget.dataset.id, -1);
        ////    });
        ////    document.querySelectorAll('.order-item-details').forEach(element => {
        ////        element.closest('.bg-gray-50').onclick = (e) => {
        ////            // Only open modal if not clicking on quantity controls or remove button
        ////            if (!e.target.closest('.decrease-order-quantity') && !e.target.closest('.increase-order-quantity') && !e.target.closest('.remove-item')) {
        ////                 openOrderDetailsModal(e.currentTarget.closest('.bg-gray-50').dataset.id);
        ////            }
        ////        };
        ////    });
        ////}

        //// Function to add item to order
        ////function addItemToOrder(name, basePrice, image, description) {
        ////    const newItem = {
        ////        id: `item-${Date.now()}-${Math.random().toString(36).substring(2, 9)}`, // Unique ID for each item instance
        ////        name: name,
        ////        basePrice: parseFloat(basePrice),
        ////        quantity: 1,
        ////        image: image,
        ////        description: description,
        ////        extras: [],
        ////        size: 'm', // Default size
        ////        note: ''
        ////    };
        ////    order.push(newItem);
        ////    renderOrder();
        ////}

        //// Function to update item quantity in order
        ////function updateOrderItemQuantity(id, change) {
        ////    const itemIndex = order.findIndex(item => item.id === id);
        ////    if (itemIndex > -1) {
        ////        order[itemIndex].quantity += change;
        ////        if (order[itemIndex].quantity <= 0) {
        ////            order.splice(itemIndex, 1); // Remove if quantity is 0 or less
        ////        }
        ////    }
        ////    renderOrder();
        ////}

        //// Function to remove item from order
        ////function removeItem(id) {
        ////    order = order.filter(item => item.id !== id);
        ////    renderOrder();
        ////}

        ////// Event listener for confirm process button
        ////confirmProcessButton.addEventListener('click', () => {
        ////    // In a real system, this would send the order to a backend.
        ////    // For this demo, we'll just clear the order and show a message.
        ////    order = [];
        ////    renderOrder();
        ////    showMessageBox('تم تأكيد الطلب!');
        ////});

        //// Event listener for coupon code (basic implementation)
        //applyCouponButton.addEventListener('click', () => {
        //    const couponCode = couponCodeInput.value.trim().toUpperCase();
        //    if (couponCode === 'COUPON20') { // Example coupon
        //        // Apply a discount, e.g., 20 EGP off
        //        const currentTotalText = totalElement.textContent.replace(' EGP', '').replace(' (تم تطبيق الخصم!)', '');
        //        const currentTotal = parseFloat(currentTotalText);
        //        const newTotal = Math.max(0, currentTotal - 20); // Ensure total doesn't go below 0
        //        totalElement.textContent = `${newTotal.toFixed(0)} EGP (تم تطبيق الخصم!)`;
        //        showMessageBox('تم تطبيق قسيمة "COUPON20" بنجاح!');
        //    } else {
        //        showMessageBox('رمز القسيمة غير صالح');
        //    }
        //});

        //// Function to switch views
        ////function showView(viewId) {
        ////    // Hide all main content views
        ////    cashierView.classList.add('hidden');
        ////    orderHistoryView.classList.add('hidden');
        ////    orderListView.classList.add('hidden');
        ////    settingsView.classList.add('hidden');

        ////    // Show the selected view and ensure it takes full width
        ////    activeView.classList.remove('hidden');
        ////    activeView.classList.add('w-full'); // Ensure the active view takes full width of its parent container

        ////    // Update active state of sidebar links
        ////    sidebarLinks.forEach(link => {
        ////        if (link.dataset.target === viewId) {
        ////            link.classList.add('bg-blue-100', 'text-blue-600', 'shadow-md');
        ////            link.classList.remove('text-gray-500', 'hover:bg-gray-100');
        ////        } else {
        ////            link.classList.remove('bg-blue-100', 'text-blue-600', 'shadow-md');
        ////            link.classList.add('text-gray-500', 'hover:bg-gray-100');
        ////        }
        ////    });

        ////    // Special handling for product management view to re-render products and categories
        ////    if (viewId === 'settings-view') {
        ////        showSettingContent('product-management'); // Default to product-management when settings is opened
        ////    }
        ////    renderCategoryButtons(cashierCategoriesContainer); // Always render categories for cashier view (default)
        ////}

        //// Add event listeners for sidebar navigation
        ////sidebarLinks.forEach(link => {
        ////    link.addEventListener('click', (e) => {
        ////        e.preventDefault();
        ////        showView(e.currentTarget.dataset.target);
        ////    });
        //    //});



        //// --- Order Details Modal Logic ---

        //function updateDetailModalTotal() {
        //    if (!currentEditingItem) return;

        //    let currentBasePrice = currentEditingItem.basePrice;
        //    let extraCost = 0;
        //    const selectedExtras = Array.from(extraOptionsContainer.querySelectorAll('input[name="extra"]:checked')).map(cb => cb.value);
        //    selectedExtras.forEach(extra => {
        //        extraCost += extraOptionsData[extra] ? extraOptionsData[extra].price : 0;
        //    });

        //    const selectedSizeElement = sizeOptionsContainer.querySelector('input[name="size"]:checked');
        //    const sizeMultiplier = selectedSizeElement ? parseFloat(selectedSizeElement.dataset.priceMultiplier) : 1.0;

        //    const calculatedTotal = (currentBasePrice + extraCost) * sizeMultiplier;
        //    detailItemTotal.textContent = `${calculatedTotal.toFixed(0)} EGP`;
        //}

        //function openOrderDetailsModal(itemId) {
        //    currentEditingItem = order.find(item => item.id === itemId);
        //    if (!currentEditingItem) return;

        //    // Populate modal with item details
        //    detailItemImage.src = currentEditingItem.image;
        //    detailItemName.textContent = currentEditingItem.name;
        //    detailItemDescription.textContent = currentEditingItem.description || '';
        //    detailAddNote.value = currentEditingItem.note || '';

        //    // Reset and set extra checkboxes
        //    extraOptionsContainer.querySelectorAll('input[name="extra"]').forEach(checkbox => {
        //        checkbox.checked = currentEditingItem.extras.includes(checkbox.value);
        //    });

        //    // Reset and set size radio buttons
        //    sizeOptionsContainer.querySelectorAll('input[name="size"]').forEach(radio => {
        //        radio.checked = (radio.value === currentEditingItem.size);
        //    });

        //    updateDetailModalTotal();
        //    orderDetailsModal.style.display = 'flex';
        //}

        //closeDetailModalButton.addEventListener('click', () => {
        //    orderDetailsModal.style.display = 'none';
        //});

        //// Event listeners for changes in extras and size to update total
        //extraOptionsContainer.addEventListener('change', updateDetailModalTotal);
        //sizeOptionsContainer.addEventListener('change', updateDetailModalTotal);


        //detailDoneButton.addEventListener('click', () => {
        //    if (currentEditingItem) {
        //        // Update extras
        //        currentEditingItem.extras = Array.from(extraOptionsContainer.querySelectorAll('input[name="extra"]:checked')).map(cb => cb.value);

        //        // Update note
        //        currentEditingItem.note = detailAddNote.value.trim();

        //        // Update size
        //        const selectedSizeElement = sizeOptionsContainer.querySelector('input[name="size"]:checked');
        //        currentEditingItem.size = selectedSizeElement ? selectedSizeElement.value : 'm';

        //        // Re-calculate the item's price and update the main order
        //        currentEditingItem.price = calculateItemPrice(currentEditingItem);
        //        renderOrder();
        //    }
        //    orderDetailsModal.style.display = 'none';
        //});


        //// --- Settings View Logic ---
        //const settingsSubLinks = document.querySelectorAll('.settings-sub-link');
        //const settingContents = document.querySelectorAll('.setting-content');

        //function showSettingContent(targetId) {
        //    settingContents.forEach(content => {
        //        content.classList.add('hidden');
        //    });
        //    document.getElementById(`setting-content-${targetId}`).classList.remove('hidden');

        //    settingsSubLinks.forEach(link => {
        //        if (link.dataset.settingTarget === targetId) {
        //            link.classList.add('bg-blue-100', 'text-blue-600', 'shadow-md');
        //            link.classList.remove('text-gray-700', 'hover:bg-gray-100');
        //        } else {
        //            link.classList.remove('bg-blue-100', 'text-blue-600', 'shadow-md');
        //            link.classList.add('text-gray-700', 'hover:bg-gray-100');
        //        }
        //    });

        //    // Re-render content based on the active setting tab
        //    if (targetId === 'product-management') {
        //        renderProductManagementList();
        //        renderCategoryButtons(productManagementCategoriesContainer, true); // Render categories for management view
        //    } else if (targetId === 'profile') {
        //        populateProfileSettings(); // Populate profile fields when profile tab is active
        //    } else if (targetId === 'extras') {
        //        renderExtrasManagement(); // Render extras list when extras tab is active
        //    } else if (targetId === 'language') {
        //        renderLanguageSettings(); // Render language settings
        //    }
        //}

        //settingsSubLinks.forEach(link => {
        //    link.addEventListener('click', (e) => {
        //        e.preventDefault();
        //        showSettingContent(e.currentTarget.dataset.settingTarget);
        //    });
        //});

        //// --- Add/Edit Dish Modal Logic ---

        //function resetAddEditDishModal() {
        //    addEditDishModalTitle.textContent = 'إضافة طبق جديد';
        //    newDishItemId.value = `autogenerated-${Date.now()}`; // Generate a new ID
        //    newDishName.value = '';
        //    newDishDescription.value = '';
        //    newDishPrice.value = '';
        //    newDishCategory.value = '';
        //    newDishPrepareTime.value = '';
        //    newDishCalories.value = '';
        //    newDishCanDeliver.checked = false;
        //    dishImagePreview.classList.add('hidden');
        //    dishImagePreview.src = '';
        //    dishImageUpload.value = ''; // Clear the file input
        //    currentEditingProduct = null; // Clear the editing state
        //}

        //function openAddEditDishModal(productId = null) {
        //    resetAddEditDishModal(); // Always reset first

        //    if (productId) {
        //        currentEditingProduct = products.find(p => p.id === productId);
        //        if (currentEditingProduct) {
        //            addEditDishModalTitle.textContent = 'تعديل طبق';
        //            newDishItemId.value = currentEditingProduct.id;
        //            newDishName.value = currentEditingProduct.name;
        //            newDishDescription.value = currentEditingProduct.description;
        //            newDishPrice.value = currentEditingProduct.basePrice;
        //            newDishCategory.value = currentEditingProduct.category;
        //            newDishPrepareTime.value = currentEditingProduct.prepareTime;
        //            newDishCalories.value = currentEditingProduct.calories;
        //            newDishCanDeliver.checked = currentEditingProduct.canDeliver;
                    
        //            if (currentEditingProduct.image) {
        //                dishImagePreview.src = currentEditingProduct.image;
        //                dishImagePreview.classList.remove('hidden');
        //            } else {
        //                dishImagePreview.classList.add('hidden');
        //                dishImagePreview.src = '';
        //            }

        //            // Set the size dropdown
        //            newDishSize.value = currentEditingProduct.size || ''; // Default to empty if not set
        //        }
        //    }
        //    addEditDishModal.style.display = 'flex';
        //}

        //addNewDishCard.addEventListener('click', () => {
        //    openAddEditDishModal(); // Call with no product ID to open in add mode
        //});

        //closeAddEditDishModalButton.addEventListener('click', () => {
        //    addEditDishModal.style.display = 'none';
        //});

        //dishImageUpload.addEventListener('change', (event) => {
        //    const file = event.target.files[0];
        //    if (file) {
        //        const reader = new FileReader();
        //        reader.onload = (e) => {
        //            dishImagePreview.src = e.target.result;
        //            dishImagePreview.classList.remove('hidden');
        //        };
        //        reader.readAsDataURL(file);
        //    } else {
        //        dishImagePreview.classList.add('hidden');
        //        dishImagePreview.src = '';
        //    }
        //});

        //saveDishButton.addEventListener('click', () => {
        //    const productData = {
        //        id: newDishItemId.value,
        //        name: newDishName.value.trim(),
        //        basePrice: parseFloat(newDishPrice.value),
        //        description: newDishDescription.value.trim(),
        //        image: dishImagePreview.src || 'https://placehold.co/100x100/e0f2fe/1e40af?text=Dish', // Default image
        //        category: newDishCategory.value.trim(),
        //        prepareTime: parseInt(newDishPrepareTime.value) || 0,
        //        calories: parseInt(newDishCalories.value) || 0,
        //        canDeliver: newDishCanDeliver.checked,
        //        size: newDishSize.value // Save selected size
        //    };

        //    // Basic validation
        //    if (!productData.name || isNaN(productData.basePrice) || !productData.category) {
        //        showMessageBox('الرجاء ملء جميع الحقول المطلوبة: الاسم، السعر، والفئة.');
        //        return;
        //    }

        //    if (currentEditingProduct) {
        //        // Update existing product
        //        const index = products.findIndex(p => p.id === currentEditingProduct.id);
        //        if (index !== -1) {
        //            products[index] = { ...products[index], ...productData }; // Merge existing with new data
        //        }
        //    } else {
        //        // Add new product
        //        products.push(productData);
        //    }

        //    renderProducts(); // Update products on the cashier view
        //    renderProductManagementList(); // Update products on the product management view
        //    addEditDishModal.style.display = 'none'; // Hide the modal

        //    const successMessage = currentEditingProduct ? `تم تحديث الطبق "${productData.name}" بنجاح!` : `تمت إضافة الطبق الجديد "${productData.name}" بنجاح!`;
        //    showMessageBox(successMessage);
        //});

        //// Function to delete a dish (basic implementation)
        //function deleteDish(productId) {
        //    products = products.filter(p => p.id !== productId);
        //    renderProducts();
        //    renderProductManagementList();
        //    showMessageBox('تم حذف الطبق بنجاح!');
        //}

        //// New: Reset Add Category Modal
        //function resetAddCategoryModal() {
        //    newCategoryNameInput.value = '';
        //    newCategoryIconInput.value = '';
        //}

        //// Add Category Modal close button
        //closeAddCategoryModalButton.addEventListener('click', () => {
        //    addCategoryModal.style.display = 'none';
        //});

        //// New: Save New Category
        //saveNewCategoryButton.addEventListener('click', () => {
        //    const categoryName = newCategoryNameInput.value.trim();
        //    const categoryIcon = newCategoryIconInput.value.trim();

        //    if (!categoryName) {
        //        showMessageBox('الرجاء إدخال اسم الفئة.');
        //        return;
        //    }

        //    // Check if category already exists
        //    if (categories.some(cat => cat.name.toLowerCase() === categoryName.toLowerCase())) {
        //        showMessageBox('الفئة بهذا الاسم موجودة بالفعل!');
        //        return;
        //    }

        //    categories.push({
        //        name: categoryName,
        //        icon: categoryIcon || 'fas fa-question', // Default icon if none provided
        //        active: false // New categories are not active by default
        //    });

        //    renderCategoryButtons(cashierCategoriesContainer); // Update cashier categories
        //    renderCategoryButtons(productManagementCategoriesContainer, true); // Update product management categories
        //    addCategoryModal.style.display = 'none';
        //    showMessageBox(`تمت إضافة الفئة "${categoryName}" بنجاح!`);
        //});

        //// New: Populate Profile Settings fields
        //function populateProfileSettings() {
        //    profileNameInput.value = userProfile.name;
        //    profileEmailInput.value = userProfile.email;
        //    profilePhoneInput.value = userProfile.phone;
        //    profileRoleInput.value = userProfile.role;
        //}

        //// New: Save Profile Changes
        //saveProfileButton.addEventListener('click', () => {
        //    userProfile.name = profileNameInput.value.trim();
        //    userProfile.email = profileEmailInput.value.trim();
        //    userProfile.phone = profilePhoneInput.value.trim();

        //    // Basic validation for email format
        //    const emailRegex = /^[^\s]+[^\s]+\.[^\s]+$/;
        //    if (userProfile.email && !emailRegex.test(userProfile.email)) {
        //        showMessageBox('الرجاء إدخال بريد إلكتروني صالح.');
        //        return;
        //    }

        //    showMessageBox('تم حفظ تغييرات الملف الشخصي بنجاح!');
        //});

        //// --- Extras Management Logic ---

        //function renderExtrasManagement() {
        //    extrasListContainer.innerHTML = ''; // Clear existing list
        //    for (const key in extraOptionsData) {
        //        if (extraOptionsData.hasOwnProperty(key)) {
        //            const extra = extraOptionsData[key];
        //            const extraItemHtml = `
        //                <div class="flex justify-between items-center bg-white p-4 rounded-lg shadow-sm border border-gray-200">
        //                    <span class="w-1/2 font-medium text-gray-800">${extra.name}</span>
        //                    <span class="w-1/4 text-gray-600">${extra.price} EGP</span>
        //                    <div class="w-1/4 flex justify-center space-x-2">
        //                        <button class="edit-extra-button text-blue-600 hover:text-blue-800" data-extra-key="${key}">
        //                            <i class="fas fa-edit"></i>
        //                        </button>
        //                        <button class="delete-extra-button text-red-600 hover:text-red-800" data-extra-key="${key}">
        //                            <i class="fas fa-trash-alt"></i>
        //                        </button>
        //                    </div>
        //                </div>
        //            `;
        //            extrasListContainer.insertAdjacentHTML('beforeend', extraItemHtml);
        //        }
        //    }

        //    // Re-attach event listeners for edit and delete extra buttons
        //    document.querySelectorAll('.edit-extra-button').forEach(button => {
        //        button.addEventListener('click', (e) => {
        //            const extraKey = e.currentTarget.dataset.extraKey;
        //            openAddEditExtraModal(extraKey);
        //        });
        //    });

        //    document.querySelectorAll('.delete-extra-button').forEach(button => {
        //        button.addEventListener('click', (e) => {
        //            const extraKey = e.currentTarget.dataset.extraKey;
        //            // Replace confirm() with a direct action and showMessageBox for simplicity
        //            delete extraOptionsData[extraKey];
        //            renderExtrasManagement();
        //            renderOrder(); // Update order in case the deleted extra was in an item
        //            showMessageBox('تم حذف الإضافة بنجاح!');
        //        });
        //    });
        //}

        //function resetAddEditExtraModal() {
        //    addEditExtraModalTitle.textContent = 'إضافة إضافة جديدة';
        //    newExtraNameInput.value = '';
        //    newExtraPriceInput.value = '';
        //    currentEditingExtraKey = null;
        //}

        //function openAddEditExtraModal(extraKey = null) {
        //    resetAddEditExtraModal();

        //    if (extraKey && extraOptionsData[extraKey]) {
        //        currentEditingExtraKey = extraKey;
        //        addEditExtraModalTitle.textContent = 'تعديل إضافة';
        //        newExtraNameInput.value = extraOptionsData[extraKey].name;
        //        newExtraPriceInput.value = extraOptionsData[extraKey].price;
        //    }
        //    addEditExtraModal.style.display = 'flex';
        //}

        //addNewExtraButton.addEventListener('click', () => {
        //    openAddEditExtraModal();
        //});

        //closeAddEditExtraModalButton.addEventListener('click', () => {
        //    addEditExtraModal.style.display = 'none';
        //});

        //saveExtraButton.addEventListener('click', () => {
        //    const extraName = newExtraNameInput.value.trim();
        //    const extraPrice = parseFloat(newExtraPriceInput.value);

        //    if (!extraName || isNaN(extraPrice)) {
        //        showMessageBox('الرجاء إدخال اسم وسعر صالحين للإضافة.');
        //        return;
        //    }

        //    const newExtraKey = extraName.toLowerCase().replace(/\s/g, '_');

        //    if (currentEditingExtraKey) {
        //        // Update existing extra
        //        if (currentEditingExtraKey !== newExtraKey && extraOptionsData.hasOwnProperty(newExtraKey)) {
        //            showMessageBox('اسم الإضافة الجديد موجود بالفعل. يرجى اختيار اسم مختلف.');
        //            return;
        //        }
        //        const oldKey = currentEditingExtraKey;
        //        extraOptionsData[newExtraKey] = { name: extraName, price: extraPrice };
        //        if (oldKey !== newExtraKey) {
        //            delete extraOptionsData[oldKey]; // Delete old key if name changed
        //        }
        //        showMessageBox(`تم تحديث الإضافة "${extraName}" بنجاح!`);
        //    } else {
        //        // Add new extra
        //        if (extraOptionsData.hasOwnProperty(newExtraKey)) {
        //            showMessageBox('هذه الإضافة موجودة بالفعل!');
        //            return;
        //        }
        //        extraOptionsData[newExtraKey] = { name: extraName, price: extraPrice };
        //        showMessageBox(`تمت إضافة الإضافة "${extraName}" بنجاح!`);
        //    }

        //    renderExtrasManagement(); // Re-render the extras list
        //    addEditExtraModal.style.display = 'none';
        //    renderOrder(); // Update order to reflect potential extra price changes
        //});

        //function deleteExtra(extraKey) {
        //    // Replaced confirm() with direct action and message for consistency
        //    delete extraOptionsData[extraKey];
        //    renderExtrasManagement();
        //    renderOrder(); // Update order in case the deleted extra was in an item
        //    showMessageBox('تم حذف الإضافة بنجاح!');
        //}


        //// --- Language Settings Logic ---
        //function renderLanguageSettings() {
        //    languageSelect.value = currentLanguage;
        //}

        //saveLanguageButton.addEventListener('click', () => {
        //    currentLanguage = languageSelect.value;
        //    // In a real application, you would load language files and re-render the UI
        //    // For this demo, we'll just show a message.
        //    showMessageBox(`تم حفظ اللغة بنجاح إلى "${currentLanguage === 'ar' ? 'العربية' : 'English'}".`);
        //    // You might want to reload the page or update all text elements based on the new language here.
        //    // For now, we'll keep the text static as it's hardcoded in HTML.
        //});


        //// Initialize with initial items and show cashier view
        //order = [...initialItems];
        //renderOrder();
        //renderProducts(); // Initial render of products for the cashier view
       
        //renderCategoryButtons(cashierCategoriesContainer); 
   